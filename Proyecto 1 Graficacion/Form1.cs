namespace Proyecto_1_Graficacion
{
    public partial class Form : System.Windows.Forms.Form
    {
        int index;
        static Figure f;
        Point mouse;
        int pX, pY;
        float scale, rotate;
        Scene scene;
        bool isMouseDown, animate;
        
        public Form()
        {
            InitializeComponent();
            
           
            scene = new Scene(pictureBox);
            
            //Figure fig = new Figure();
            //fig.Add(new PointF(55, 120));
            //fig.Add(new PointF(pictureBox.Width-200, 120));
            //scene.Figures.Add(fig);
            index = 0;
            pY = 100;
            

        }

        private void TB_ROTATION_Scroll(object sender, EventArgs e)
        {
            f.rotation += (float)(TB_ROTATION.Value - pX);
            rotate += (float)(TB_ROTATION.Value - pX);
            pX = TB_ROTATION.Value;
        }

        

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void New_Figure_Click(object sender, EventArgs e)
        {
            f = new Figure();
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (TREE.Nodes.Count + 1));
            node.Tag = f;
            TREE.Nodes.Add(node);
            
        }

        private void TREE_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)TREE.SelectedNode.Tag;
            NEW_FIGURE.Select();
            TB_ROTATION.Value = 0;
            TB_SCALE.Value = 100;
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            pictureBox.Select();
            
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                mouse = e.Location;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TB_SCALE_MouseUp(object sender, MouseEventArgs e)
        {
            TB_SCALE.Value = 100;
            pY = 100;
        }

        private void TB_SCALE_Scroll(object sender, EventArgs e)
        {
            
            f.scale += (float)(pY - TB_SCALE.Value) / 100;
            scale += (float)(pY-TB_SCALE.Value)/100 ;
            pY= TB_SCALE.Value;
            
           
             

        }

        private void TB_MOVE_Scroll(object sender, EventArgs e)
        {
            
        }
        private void NEW_FRAME_Click(object sender, EventArgs e)
        {
            foreach(Figure figure in scene.Figures)
            {
                figure.changesQueue.Add(new Changes(TB_FRAMES.Value, figure.Centroid, figure.scale, figure.rotation));
            }
        }

        private void TB_FRAMES_Scroll(object sender, EventArgs e)
        {
        }

        private void Animate_Click(object sender, EventArgs e)
        {
            Animate.Text = "STOP";
            animate = true;
            Animate.Click += new EventHandler(Stop_Click);
            foreach(Figure figure in scene.Figures)
            {
                figure.TranslateToOrigin();
                figure.Rotate(-figure.rotation);
                figure.Scale(1 / figure.scale);
                figure.TranslatePoints(figure.Centroid);
            }
           

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Animate.Text = "ANIMATE";
            animate = false;
            Animate.Click += new EventHandler(Animate_Click);
        }

        private void TB_ROTATION_MouseUp(object sender, MouseEventArgs e)
        {
            TB_ROTATION.Value = 0;
        }





        /*Funcion que se encarga de trazar las figuras y poner las constantes en 0 y 1 cuando son necesarios
         * 
         */
        private void TIMER_Tick(object sender, EventArgs e)
        {
            if (f != null )
            {
                f.TranslateToOrigin();
                f.Scale(scale);
                f.Rotate(rotate);
                f.TranslatePoints(f.Centroid);
            }
            if (animate) {
                if (index == TB_FRAMES.Maximum)
                {
                    TB_FRAMES.Value = 0;
                    index = 0;
                    
                }
                else
                {
                    TB_FRAMES.Value = ++index;
                }
                
                for(int i=0; i < scene.Figures.Count; i++)
                {
                    Figure figure= scene.Figures[i];
   
                    Changes change1 ;
                    Changes change2 ;
                    
                    for(int j = 0; j < figure.changesQueue.Count-1; j++)
                    {
                        if (TB_FRAMES.Value == 0) {
                            figure.TranslateToOrigin();
                            figure.Rotate(-figure.rotation);
                            figure.Scale(1 / figure.scale);
                            figure.TranslatePoints(figure.Centroid);
                        }
                        if (isBetween(figure.changesQueue[j], figure.changesQueue[j+1])) {
                            change1= figure.changesQueue[j];
                            change2= figure.changesQueue[j+1];
                            if (figure.changesQueue[figure.changesQueue.Count-1].position.Equals( figure.Centroid))
                            {
                                figure.TranslatePoints(figure.Centroid);
                                figure.UpdateAttributes();

                            }
                            else
                            { 
                                figure.TranslateToOrigin();
                                float scalation = Math.Abs((change1.scalation - change2.scalation) / (change2.frame - change1.frame));
                                if (change1.scalation < change2.scalation)
                                {
                                    scalation += 1;
                                }
                                else if(change1.scalation > change2.scalation)
                                {
                                    scalation = 1 - scalation;
                                }
                                figure.Scale(scalation);
                                figure.Rotate((change1.rotation - change2.rotation) / (change1.frame - change2.frame));
                                figure.TranslatePoints(figure.Centroid);
                                figure.Follow(change1.position, change2.position, (float)TB_FRAMES.Value / change2.frame);

                            }
                            break;
                        }
                            
                    }
                }

                
            }
            
            rotate = 0;
            scale = 1;
            scene.Render();
        }
        private bool isBetween(Changes change1, Changes change2)
        {
            if(TB_FRAMES.Value >= change1.frame && TB_FRAMES.Value <= change2.frame)
            {
                return true;
            }
            return false;
        }
    }
}
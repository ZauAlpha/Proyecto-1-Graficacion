namespace Proyecto_1_Graficacion
{
    public partial class Form : System.Windows.Forms.Form
    {
        static Figure f;
        Point mouse;
        int pX, pY;
        float scale, rotate;
        List<Scene> scenes;
        Scene scene;
        bool isMouseDown;
        public Form()
        {
            InitializeComponent();
            
           
            scene = new Scene(pictureBox);
            scenes= new List<Scene>();
            scenes.Add(scene);
            Figure fig = new Figure();
            fig.Add(new PointF(55, 120));
            fig.Add(new PointF(1100, 120));
            scene.Figures.Add(fig);
            TB_FRAMES.Maximum = scenes.Count-1;
            pY = 100;

        }

        private void TB_ROTATION_Scroll(object sender, EventArgs e)
        {
            
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
            /*
             * rotate += (float)(TB_ROTATION.Value - pX)/3;
             * pX = TB_ROTATION.Value;
             * 
             * 
             *  deltaY += (float)(ptY.Y - e.Location.Y) / 500;// delta y= escale
             *  ptY.Y = e.Location.Y;
             */
            scale += (float)(pY-TB_SCALE.Value)/100 ;
            pY= TB_SCALE.Value;
           
             

        }

        private void TB_MOVE_Scroll(object sender, EventArgs e)
        {
            f.Follow(scene.Figures[0].Pts[0], scene.Figures[0].Pts[1], (float)TB_MOVE.Value / 100);
        }

        private void ADD_SCENE_Click(object sender, EventArgs e)
        {
            Scene newScene = new Scene(pictureBox);
            scenes.Add(newScene);
            TB_FRAMES.Maximum= scenes.Count;
            TB_FRAMES.Value = scenes.IndexOf(newScene);
            scene = newScene;
            TREE.Nodes.Clear();
        }

        private void TB_FRAMES_Scroll(object sender, EventArgs e)
        {
           
            if(scenes.Count-1 >= TB_FRAMES.Value) {
                TREE.Nodes.Clear();
                scene = scenes[TB_FRAMES.Value];
                f = null;
                foreach (Figure figure in scene.Figures)
                {
                    TreeNode node = new TreeNode("Fig" + (scene.Figures.IndexOf(figure) + 1));
                    node.Tag = figure;
                    TREE.Nodes.Add(node);
                }
            }
            
            
        }

        private void Animate_Click(object sender, EventArgs e)
        {
            Animate.Text = "STOP"; 
            TIMER.Tick += new EventHandler(TIMER_Tick2);
            Animate.Click += new EventHandler(Stop_Click);
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            Animate.Text = "ANIMATE";
            TIMER.Tick += new EventHandler(TIMER_Tick);
            Animate.Click += new EventHandler(Animate_Click);
        }

        private void TIMER_Tick2(object sender, EventArgs e)
        {
            int index = scenes.IndexOf(scene);
            if (index == scenes.Count - 1)
                index = 0;
            else 
                index++;
            
            scene = scenes[index];
            scene.Render();
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
            rotate = 0;
            scale = 1;
            scene.Render();
        }
    }
}
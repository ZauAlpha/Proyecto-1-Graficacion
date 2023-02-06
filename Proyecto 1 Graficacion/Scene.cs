using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Graficacion
{
    class Scene
    {
       
        
        PictureBox pct;
        Bitmap bmp;
        Graphics g;
        public List<Figure> Figures;

        public Scene(Scene other) 
        {
            this.pct = other.pct;
            this.bmp = other.bmp;
            this.g = other.g;
            this.Figures= other.Figures;
            pct.Image = bmp;
            pct.Invalidate();
        }

        public Scene(PictureBox pct)
        {
            this.pct = pct;
            Figures = new List<Figure>();
            bmp= new Bitmap(pct.Width, pct.Height);
            g = Graphics.FromImage(bmp);
            pct.Image= bmp;
            pct.Invalidate();
        }
        public void Render()
        {
            g.Clear(Color.FromArgb(0,0,64));
            for (int f = 0; f < this.Figures.Count; f++)
            {
                if (this.Figures[f].Pts.Count > 1)
                {
                    
                    g.FillPolygon(Brushes.MediumTurquoise, this.Figures[f].Pts.ToArray());
                    g.DrawPolygon(Pens.Goldenrod, this.Figures[f].Pts.ToArray());
                    g.FillEllipse(Brushes.Violet, this.Figures[f].Pts[this.Figures[f].Pts.Count - 1].X - 3, this.Figures[f].Pts[this.Figures[f].Pts.Count - 1].Y - 3, 6, 6);
                    g.FillEllipse(Brushes.Yellow, this.Figures[f].Centroid.X - 3, this.Figures[f].Centroid.Y - 3, 6, 6);//*/
                }
            }
            pct.Image = bmp;
            pct.Invalidate();
        }
        
    }
}

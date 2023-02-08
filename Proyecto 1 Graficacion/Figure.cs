using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1_Graficacion
{
    /* Figura
     * tiene una lista de puntos 
     * guarda el centroide y el ultimo punto 
     * que se a añadido a la lista
     */
    public class Figure
    {
        public List<Changes> changesQueue;
        public List<PointF> Pts;
        public PointF Centroid, Last;
        public float rotation =0;
        public float scale = 1;
        

        public Figure()
        {
            Pts = new List<PointF>();
            changesQueue = new List<Changes>();
        }

        /*Añade el punto y recalcula el centroide*/
        public void Add(PointF point)
        {
            Centroid = new PointF();
            Pts.Add(point);

            for (int p = 0; p < Pts.Count; p++)
            {
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = point;

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;
        }
        /* Hace mas grande o mas pequeño la figura */
        public void Scale(float value)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X * value, Pts[p].Y * value);
            }
        }

        /* Mueve la figura */
        public void Follow(PointF a, PointF b, float value)
        {
            
            PointF pos = Util.Ins.NextStep(a, b, value);
            //Centroid = Util.Ins.NextStep(a, b, value);
            TranslateToOrigin();
            TranslatePoints(pos);
            UpdateAttributes();
        }

        public void TranslatePoints(PointF a)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X + a.X, Pts[p].Y + a.Y);
            }
        }

        public void TranslateToOrigin()
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X - Centroid.X, Pts[p].Y - Centroid.Y);
            }
        }

        public void Rotate(float angle)
        {
            for (int p = 0; p < Pts.Count; p++)
                Pts[p] = Util.Ins.Rotate(Pts[p], angle);
        }

        public void UpdateAttributes()
        {
            Centroid = new PointF();

            for (int p = 0; p < Pts.Count; p++)
            {
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = Pts[Pts.Count - 1];

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;
        }
        public override String ToString()
        {
            return "Centroid : " + Centroid.ToString() + "\n Rotation " + rotation.ToString() + "\n Scale " + scale.ToString();
        }
    }
}


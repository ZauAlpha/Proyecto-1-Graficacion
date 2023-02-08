using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Graficacion
{
    public class Changes
    {
        public int frame;
        public PointF position;
        public float scalation, rotation;

        public Changes (int frame, PointF position, float scalation, float rotation)
        {
            this.frame = frame;
            this.position = position;
            this.scalation = scalation;
            this.rotation = rotation;
        }
        public override string ToString()
        {
            return "\n Frame : "+ frame.ToString() + " PointF : "+ position.ToString()+ " \t {"+scalation.ToString()+","+rotation.ToString() + "}";
        }
    }
}

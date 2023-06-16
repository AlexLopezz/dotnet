using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGeometria.Utils
{
    public class Rectangle
    {
        private float _area;
        private float _perimeter;
        private bool _calculate;
        public Point Vertex { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }
        public Point Vertex4 { get; set; }

        public Rectangle(Point vertex, Point vertex4)
        {
            _calculate = false;
            Vertex = vertex;
            Vertex4 = vertex4;
        }

        public float GetArea()
        {
            if (_calculate)
            {
                return _area;
            }
            else
            {
                _area = 
            }
        }
        public float GetPerimeter()
        {

        }
    }
}

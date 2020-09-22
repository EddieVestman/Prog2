using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceuppgfiten
{
    class Circle : IShape
    {
        private int radius;

        public Circle(int width)
        {
            this.radius = width;
        }
        public double Area()
        {
            double area = radius * radius * Math.PI;
            return area;
        }
        public double Circumferance()
        {
            double circumferance = 2 * Math.PI * radius;
            return circumferance;
        }
    }
}

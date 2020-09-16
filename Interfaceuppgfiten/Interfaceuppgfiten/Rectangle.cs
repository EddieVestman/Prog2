using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceuppgfiten
{
    class Rectangle : IShape
    {
        private int height;
        private int width;
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
    }
    
        public double Area()
        {
            double area = width * height;
            return area;
        }

        public double Circumferance()
        {
            double circumferance = 2 * width + height * 2;
            return circumferance;
        }
    }
}


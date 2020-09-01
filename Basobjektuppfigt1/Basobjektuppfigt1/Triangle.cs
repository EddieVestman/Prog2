using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basobjektuppfigt1
{
    class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width)
        {
            

        }
        public double Area()
        {
            double area = width * height / 2;
            return area;
        }

        public double Circumferance()
        {
            double circumferance = Math.Sqrt(width * width + height * height);
            return circumferance;
        }
    }
}
    


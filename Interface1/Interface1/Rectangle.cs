using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismupg1
{
    class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width)
        {

        }
        public override double Area()
        {
            double area = width * height;
            return area;
        }

        public override double circumferance()
        {
            double circumferance = 2 * width + height * 2;
            return circumferance;
        }
    }
}
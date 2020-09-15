using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismupg1
{
    class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width)
        {


        }
        public override double Area()
        {
            double area = width * height / 2;
            return area;
        }

        public override double circumferance()
        {
            double circumferance = Math.Sqrt(width * width + height * height);
            return circumferance;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoIymorfismuppgift1
{
    class Shape
    {
        protected int height;
        protected int width;

        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;

        }

        public virtual double Area()
        {
            return 1;
        }
        public virtual double Circumferance()
        {
            return 1;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basobjektuppfigt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en höjd och bredd");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Rectangle rec = new Rectangle(width, height);
            Triangle tri = new Triangle(width, height);


            Console.WriteLine(rec.Area());
            Console.WriteLine(tri.Area());
            Console.WriteLine(rec.Circumferance());
            Console.WriteLine(tri.Circumferance());

        }
    }
}

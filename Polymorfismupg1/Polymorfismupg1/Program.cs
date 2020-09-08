using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfismupg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du räkna på en rätvinklig traingle eller rektangel?");
               
            Console.WriteLine("Skriv in en höjd och bredd");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Rectangle rec = new Rectangle(width, height);
            Triangle tri = new Triangle(width, height);


            Console.WriteLine(rec.Area());
            Console.WriteLine(tri.Area());
            Console.WriteLine(rec.circumferance());
            Console.WriteLine(tri.circumferance());

            Shape shape = new Triangle(width, height);
            Shape shape1 = new Rectangle(width, height);

        }
    }
}
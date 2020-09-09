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
            Console.WriteLine("Vill du räkna på en rätvinklig triangel eller rektangel?");
            string answer = Console.ReadLine();

            if (answer == "triangel")
            {
                Console.WriteLine("Skriv in en höjd och bredd");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                Shape tri = new Triangle(width, height);
                Console.WriteLine(tri.Area());
                Console.WriteLine(tri.circumferance());

            }
            else if (answer == "recntagle")
            {
                Console.WriteLine("Skriv in en höjd och bredd");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = Convert.ToInt32(Console.ReadLine());
                Shape rec = new Rectangle(width, height);
                Console.WriteLine(rec.Area());
                Console.WriteLine(rec.circumferance());
            }
            else
            {
                Console.WriteLine("Välj en!");


            }


        }
    }
}
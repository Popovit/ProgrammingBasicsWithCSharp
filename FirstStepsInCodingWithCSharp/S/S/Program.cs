using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();



            if (figures == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);

            }
            else if (figures == "rectangle" )
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figures == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else if (figures == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(a * h / 2);
            }
            Console.ReadLine();
        }
    }
}

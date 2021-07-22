using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double gradus = radian * 180 / Math.PI;
            Console.WriteLine(Math.Round(gradus));

            Console.ReadKey();

        }
    }
}

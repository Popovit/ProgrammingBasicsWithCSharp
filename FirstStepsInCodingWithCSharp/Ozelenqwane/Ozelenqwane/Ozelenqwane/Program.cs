using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozelenqwane
{
    class Program
    {
        static void Main(string[] args)
        {
            int ozeleneni = int.Parse(Console.ReadLine());
            double ivan = 7.61;
            double gosho = ozeleneni * ivan;
            double discount = 0.18; 
            double petur = discount * gosho;
            double vankata = gosho - petur;
            Console.WriteLine("The final price is:" + " " + vankata);
            Console.WriteLine("Your discount is:" + " " + petur);

            Console.ReadLine();

        }
    }
}

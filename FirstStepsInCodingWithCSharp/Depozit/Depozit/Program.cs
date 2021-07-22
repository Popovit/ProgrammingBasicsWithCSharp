using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depozit
{
    class Program
    {
        static void Main(string[] args)
        {
            double depSUM = double.Parse(Console.ReadLine());
            double depSROK = double.Parse(Console.ReadLine());
            double procentgodishen = double.Parse(Console.ReadLine());
            double natlihwa;
            natlihwa = depSUM * 5.7/100; //Natrupana Lihwa
            double ivan;
            ivan = natlihwa / 12;
            double obsht = depSUM + ((depSROK) * ivan);
            



            
                Console.WriteLine($"Вие получавате {obsht} в края на депозитния период !");


            Console.ReadLine();
        }
    }
}

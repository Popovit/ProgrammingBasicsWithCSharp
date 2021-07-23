using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akvarium
{
    class Program
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());   //Дължина в см.
            double width = double.Parse(Console.ReadLine());// Широчина в см.
            double height = double.Parse(Console.ReadLine());//Височина в см.
            double procent = double.Parse(Console.ReadLine());//Процент.
            double capacity = lenght * width * height;
            double litersOfAquarium = capacity * 0.001;
            double procentSum = procent * 0.01;
            double litersSum = litersOfAquarium * (1 - procentSum);
            Console.WriteLine(litersSum);
            Console.ReadKey();





        }
    }
}

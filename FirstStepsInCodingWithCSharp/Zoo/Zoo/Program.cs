using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            double ivan = double.Parse(Console.ReadLine());
            double gosho = double.Parse(Console.ReadLine());
            double dogs = 2.5;
            double others = 4;

            double sum = (ivan * dogs) + (gosho * others);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}

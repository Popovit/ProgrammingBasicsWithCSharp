using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num1 = double.Parse(Console.ReadLine());

            if (num > num1)
            {

                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num1);
            }
            Console.ReadKey();
        }
    }
}

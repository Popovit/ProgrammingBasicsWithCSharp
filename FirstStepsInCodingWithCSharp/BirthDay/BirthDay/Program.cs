using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
       
        {
            double naem = double.Parse(Console.ReadLine());
            double torta = naem * 20 / 100;
            double napitki = torta - 45.0 / 100.0  * torta;
            double animator = 1.0/3.0 * naem;
            Console.WriteLine(naem + torta + napitki + animator);
            Console.WriteLine(napitki);
        
            Console.ReadKey();

        }
    }
}

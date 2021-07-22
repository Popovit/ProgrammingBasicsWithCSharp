using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaduljitelnaLiteratura
{
    class Program
    {
        static void Main(string[] args)
        {
            double broistranici = double.Parse(Console.ReadLine());
            double prochete = double.Parse(Console.ReadLine());
            double broidni = double.Parse(Console.ReadLine());
            double ivan = broistranici / prochete;
            double drao = ivan / broidni;
            Console.WriteLine(drao);
            Console.ReadLine();
        }
    }
}

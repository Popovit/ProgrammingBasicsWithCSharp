using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string LastName = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine(Name + " " + LastName + " " + "е" + " " + "на" + " " + Age + "години" + " " + "от" + " " + town + "!");
            Console.ReadLine();

            
        }
    }
}

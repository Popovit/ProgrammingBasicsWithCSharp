using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlagotvoritelnaKampaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDays = int.Parse(Console.ReadLine());
            int numOfMakers = int.Parse(Console.ReadLine());
            int numOfCake = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancake = int.Parse(Console.ReadLine());
            double cake = numOfCake * 45;
            double waffles = numOfWaffles * 5.80;
            double pancake = numOfPancake * 3.20;
            double sumPerDay = (cake + waffles + pancake) * numOfMakers;
            double wholeSum = sumPerDay * numOfDays;
            double afterCosts = wholeSum - 0.125 * wholeSum;
            Console.WriteLine(afterCosts);
            Console.ReadLine();


 






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете примерна цена на ягодите:");
            double PriceOfStrawberries = double.Parse(Console.ReadLine()); // Цена на ягодите в лева.
            Console.WriteLine("Моля въведете примерно  количество на бананите:");
            double QuantityOfBananas = double.Parse(Console.ReadLine()); // Количество на бананите в килограми.
            Console.WriteLine("Моля въведете примерно  количество на портокалите:");
            double QuantityOfOranges = double.Parse(Console.ReadLine()); //Количество на портокалите в килограми.
            Console.WriteLine("Моля въведете примерно  количество на малините:");
            double QuantityOfRaspberries = double.Parse(Console.ReadLine()); // Количество на малините в килограми.
            Console.WriteLine("Моля въведете примерно  количество на ягодите:");
            double QuantityOfStrawberries = double.Parse(Console.ReadLine()); //Количество на ягодите в килограми.
            double PriceOfRasberries = PriceOfStrawberries / 2; //цената на малините е на половина по-ниска от тази на ягодите;
            double PriceOfOranges = PriceOfRasberries - (0.4 * PriceOfRasberries); //цената на портокалите е с 40% по-ниска от цената на малините;
            double PriceOfBananas = PriceOfRasberries - (0.8 * PriceOfRasberries); //цената на бананите е с 80% по-ниска от цената на малините.
            double SumOfRasberries = QuantityOfRaspberries * PriceOfRasberries;
            double SumOfOranges = QuantityOfOranges * PriceOfOranges;
            double SumOfBananas = QuantityOfBananas * PriceOfBananas;
            double SumOfStrawberries = QuantityOfStrawberries * PriceOfStrawberries;
            double SUM = SumOfBananas + SumOfOranges + SumOfRasberries + SumOfStrawberries;
            Console.WriteLine($"Тук се изписва общата сума:{SUM:f2}лв !");
            Console.ReadKey();








        }
    }
}

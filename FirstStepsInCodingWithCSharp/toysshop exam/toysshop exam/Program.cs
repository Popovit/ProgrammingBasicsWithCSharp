using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toysshop_exam
{
    class Program
    {
        static void Main(string[] args)
        {
   

               double priceOfTrip = double.Parse(Console.ReadLine()); //Цена на екскурзията
               double quantityOfpuzzle = double.Parse(Console.ReadLine()); // Брой пъзели
               double quantityOfDolls = double.Parse(Console.ReadLine()); // Брой говорещи кукли
               double quantityOfBears = double.Parse(Console.ReadLine()); //Брой плюшени мечета
               double quantityOfminions = double.Parse(Console.ReadLine()); //Брой миньони
               double quantityOftrucks = double.Parse(Console.ReadLine()); //Брой камиончета
               double sum = quantityOfpuzzle * 2.60 + quantityOfDolls * 3 + quantityOfBears * 4.10 + quantityOfminions * 8.20 + quantityOftrucks * 2;
               double quantityOfToys = quantityOfpuzzle + quantityOfDolls + quantityOfBears + quantityOfminions + quantityOftrucks;

               if (quantityOfToys>= 50)
        {
                double dis = 0.25 * sum;
                double totalSum = sum - dis;
                double rent = 0.10 * totalSum;
                double profit = totalSum - rent;
                double left = profit - priceOfTrip;
                Console.WriteLine($"Yes! {left:f2} lv left. ");
        }
               else if (quantityOfToys<=50)
        {
                double rent = 0.10 * sum;
                double profit = sum - rent;
                double needed = priceOfTrip - profit;
                Console.WriteLine($"Not enough money! {needed:f2} lv needed.");
        }
          
}

}
}

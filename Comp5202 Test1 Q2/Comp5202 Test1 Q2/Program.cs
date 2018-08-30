using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp5202_Test1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNumber;
            float myAverage = 0;
            Console.WriteLine("This program will ask for 10 numbers and return the average");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i} - Please input a number: ");
                myNumber = Convert.ToInt32(Console.ReadLine());
                myAverage += myNumber;
            }
            myAverage = myAverage / 10;
            Console.WriteLine($"The average of your numbers is {myAverage}");
            Console.ReadLine();
        }
    }
}

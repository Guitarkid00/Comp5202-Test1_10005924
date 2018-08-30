using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp5202_Test1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will tell you if the number you input is even or odd");
            Console.Write("Please enter a number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            int myOddEven = myNumber % 2;
            if (myOddEven == 0)
            {
                Console.WriteLine($"{myNumber} is an even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{myNumber} is an odd number");
                Console.ReadLine();
            }
        }
    }
}

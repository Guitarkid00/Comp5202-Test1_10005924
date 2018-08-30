using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp5202_Test1_q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int myN;
            int myM;
            int myX;
            int myBlank;
            string myMiddle;
            Console.WriteLine("This program will expand a quadratic equation for you");
            Console.WriteLine("It will be based on the following layout:");
            Console.WriteLine("(x + n)(x + m)");
            Console.Write("Please enter a number for n: ");
            myN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a number for m: ");
            myM = Convert.ToInt32(Console.ReadLine());
            myX = myN + myM;
            if(myX > 0)
            {
                myMiddle = ($"+{myX}");
            }
            else
            {
                myMiddle = ($"{myX}");
            }
            myBlank = myN * myM;
            if (myMiddle == "0")
            {
                Console.WriteLine($"Your expanded equation is 2^x {myBlank}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Your expanded equation is: x^2 {myMiddle}x {myBlank}");
                Console.ReadLine();
            }
        }
    }
}

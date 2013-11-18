using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintGreaterNumber
{
    //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
    class PrintGreaterNumber
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNumber = 0;
            bool firstNumberIsBigger = (firstNumber > secondNumber);
            biggerNumber = firstNumberIsBigger ? firstNumber : secondNumber;
            Console.WriteLine(biggerNumber);
        }
    }
}

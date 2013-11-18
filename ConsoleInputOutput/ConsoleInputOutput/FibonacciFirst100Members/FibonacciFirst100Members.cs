namespace FibonacciFirst100Members
{
    using System;
    class FibonacciFirst100Members
    {
        //Write a program to print the first 100 members of the sequence of Fibonacci: 
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        static void Main()
        {
            ulong current1 = 0, current2 = 1, current3 = 1;
            Console.Write("0, 1, 1, ");
            for (int i = 0; i < 98; i++) //изпълнява се 98 пъти
            {
                current1 = current2;
                current2 = current3;
                current3 = current1 + current2;
                Console.Write("{0}, ", current3);
            }
        }
    }
}

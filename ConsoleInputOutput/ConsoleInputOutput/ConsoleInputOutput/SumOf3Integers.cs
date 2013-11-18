namespace ConsoleInputOutput
{
    using System;
    class SumOf3Integers
    {
        //Write a program that reads 3 integer numbers from the console and prints their sum.
        static void Main()
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int sum = firstInteger + secondInteger + thirdInteger;
            Console.WriteLine(sum);
        }
    }
}

namespace SumOfN
{
    using System;
    class SumOfN
    {
        //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int current = 0, sum = 0;
            for (int i = 0; i < n; i++)
            {
                current = int.Parse(Console.ReadLine());
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}

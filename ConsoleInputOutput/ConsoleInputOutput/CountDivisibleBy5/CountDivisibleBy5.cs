namespace CountDivisibleBy5
{
    using System;
    class CountDivisibleBy5
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between
        //them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
        static void Main()
        {
            int left = int.Parse(Console.ReadLine());
            int right = int.Parse(Console.ReadLine());
            int count = (right - left) / 5 + 1;
            Console.WriteLine(count);
        }
    }
}

namespace SickSum
{
    using System;
    class SickSum
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        static void Main()
        {
            decimal sum = 1;
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 1.0m / i;
                }
                else
                {
                    sum -= 1.0m / i;
                }
            }
            Console.WriteLine("{0:0.000}", sum);
        }
    }
}

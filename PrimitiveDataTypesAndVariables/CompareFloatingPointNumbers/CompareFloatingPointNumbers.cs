namespace CompareFloatingPointNumbers
{
    using System;
    class CompareFloatingPointNumbers
    {
        //Write a program that safely compares floating-point numbers with precision of 0.000001. 
        //Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

        static void Main()
        {
            decimal first = 0;
            decimal second = 0;
            Console.WriteLine("We are about to compare two floating point numbers");
            Console.Write("Enter first floating-point number: ");
            first = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second floating-point number: ");
            second = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0} > {1}? {2}", first, second, (first > second));
        }
    }
}

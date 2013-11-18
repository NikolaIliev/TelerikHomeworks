namespace QuadraticEquation
{
    using System;
    class QuadraticEquation
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and 
        //solves it (prints its real roots).
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = (b * b) - (4 * a * c);
            double firstRoot = 0, secondRoot = 0;
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots!");
            }
            else if (discriminant >= 0)
            {
                firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("First root: {0}", firstRoot);
                Console.WriteLine("Second root: {0}", secondRoot);
            }
        }
    }
}

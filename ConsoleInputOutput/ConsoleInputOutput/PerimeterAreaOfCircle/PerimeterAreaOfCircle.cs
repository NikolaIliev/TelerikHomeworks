namespace PerimeterAreaOfCircle
{
    using System;
    class PerimeterAreaOfCircle
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area.
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
        }
    }
}

namespace NullValues
{
    using System;
    class NullValues
    {
        //Create a program that assigns null values to an integer and to double variables. 
        //Try to print them on the console, try to add some values or the null literal to them and see the result.

        static void Main(string[] args)
        {
            int? nullInteger = null;
            double? nullDouble = null;
            Console.WriteLine(nullInteger);
            Console.WriteLine(nullDouble);
            nullInteger += null;
            nullDouble += 0.5;
            Console.WriteLine(nullInteger);
            Console.WriteLine(nullDouble);
        }
    }
}

﻿namespace ObjectAndTypeCasting
{
    using System;
    class ObjectAndTypeCasting
    {
        //Declare two string variables and assign them with “Hello” and “World”. 
        //Declare an object variable and assign it with the concatenation of the first two variables 
        //(mind adding an interval). Declare a third string variable and initialize it with the value of the 
        //object variable (you should perform type casting).

        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concat = hello + " " + world;
            string helloWorld = (string)concat;
        }
    }
}

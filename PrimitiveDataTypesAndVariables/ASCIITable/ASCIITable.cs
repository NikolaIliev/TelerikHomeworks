﻿namespace ASCIITable
{
    using System;
    class ASCIITable
    {
        //Find online more information about ASCII (American Standard Code for Information Interchange) 
        //and write a program that prints the entire ASCII table of characters on the console.

        static void Main()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine("{0}: {1} ", i, (char)i);
            }
        }
    }
}

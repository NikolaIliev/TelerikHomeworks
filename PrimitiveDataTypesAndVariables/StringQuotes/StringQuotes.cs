namespace StringQuotes
{
    using System;
    class StringQuotes
    {
        //Declare two string variables and assign them with following value:
        //The "use" of quotations causes difficulties
        //Do the above in two different ways: with and without using quoted strings.

        static void Main()
        {
            string withoutQuotedStrings = "the \"use\" of quotations causes difficulties";
            string withQuotedStrings = @"The ""use"" of quotations causes difficulties";
        }
    }
}

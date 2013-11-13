namespace ExchangeValues
{
    using System;
    class ExchangeValues
    {
        //Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
        static void Main()
        {
            int firstInteger = 5, secondInteger = 10, help = 0;
            help = firstInteger;
            firstInteger = secondInteger;
            secondInteger = help;
        }
    }
}

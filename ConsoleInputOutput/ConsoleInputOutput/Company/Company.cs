namespace Company
{
    using System;
    class Company
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, 
        //last name, age and a phone number. Write a program that reads the information about a company and its
        //manager and prints them on the console.
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string companyWebSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine("Company name: {0}", companyName);
            Console.WriteLine("Company address: {0}", companyAddress);
            Console.WriteLine("Company phone number: {0}", companyPhoneNumber);
            Console.WriteLine("Company website: {0}", companyWebSite);
            Console.WriteLine("Manager first name: {0}", managerFirstName);
            Console.WriteLine("Manager address: {0}", managerLastName);
            Console.WriteLine("Manager address: {0}", managerAge);
            Console.WriteLine("Manager address: {0}", managerPhoneNumber);
        }
    }
}

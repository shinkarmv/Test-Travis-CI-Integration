using System;
using Test_Travis_CI_Integration.Models;

namespace Test_Travis_CI_Integration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started");
            Console.WriteLine("Get Country details");
            Console.WriteLine("Enter country code");
            string countryCode = Console.ReadLine();
            Response response = GetRecords.GetCountryDetails(countryCode);
            Console.WriteLine("Fetched contry details successfully");
            Console.WriteLine("Details are save at location");
            Console.ReadLine();
        }
    }
}

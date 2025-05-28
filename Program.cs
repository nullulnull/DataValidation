using System;
using System.Text.RegularExpressions;
using DataVerification.Models;
using DataVerification.Rules;
using DataVerification.Services;

namespace DataValidationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Data Validation\n");

            var user = new User();

            Console.Write("Name: ");
            user.Name = Console.ReadLine();

            Console.Write("Email: ");
            user.Email = Console.ReadLine();

            Console.Write("Phone Number: ");
            user.Phone = Console.ReadLine();

            Console.Write("Password: ");
            user.Password = Console.ReadLine();

            Console.WriteLine("\nValidation Results:\n");

            var validator = new UserValidator();
            var results = validator.Validate(user);

            foreach (var result in results)
            {
                Console.WriteLine($"{(result.IsValid ? "✅" : "❌")} {result.Message}");
            }
        }
    }
}
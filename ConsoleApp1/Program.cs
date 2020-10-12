using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth.");
            string userInput = Console.ReadLine();
            CalculateAge(userInput);
        }

        public static void CalculateAge(string yearOfBirth)
        {
            int UsersYearOfBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"You are {2020 - UsersYearOfBirth} years old.");
        }


    }
}

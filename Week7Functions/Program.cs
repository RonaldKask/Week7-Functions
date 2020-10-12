using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Age();
        }

        public static void Age()
        {
            Console.WriteLine("Enter your year of birth.");
            int age = Int32.Parse(Console.ReadLine());

            int result = 2020 - age;

            Console.WriteLine($"You are {result} years old.");
        }
    }
}

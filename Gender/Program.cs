using System;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender();
        }

        public static void Gender()
        {
            Console.WriteLine("What gender are you?");
            string userInput = Console.ReadLine();

            if (userInput == "m")
            {
                Console.WriteLine("Hello, Sir!");
            }else if (userInput == "f")
            {
                Console.WriteLine("Hello, Madam!");
            }else
            {
                Console.WriteLine("Please enter either m or f as your gender.");
            }
        }
    }
}

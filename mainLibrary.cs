using System;

namespace TerminalIOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt for input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);  // Convert string to int[web:15]

            // Output formatted result
            Console.WriteLine($"Hello, {name}! You are {age} years old.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();  // Wait for user input before closing[cite:5]
        }
    }
}

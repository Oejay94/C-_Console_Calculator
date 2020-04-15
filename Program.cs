using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number, and then press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "b":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "c":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;

            }

            Console.WriteLine("Press any key to close the Calculator Console App...");
            Console.ReadKey();
        }
    }
}

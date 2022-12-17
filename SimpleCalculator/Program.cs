using System;

namespace Simple_Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My C3 Calculator";
            Console.ForegroundColor = ConsoleColor.Green;

            double num01, num02, result;
            string operation;

            Console.Write("Enter the first number: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation(+,-,*,/): ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case ("+"):
                    result = num01 + num02;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n");
                    Console.WriteLine("The answer is " + result);
                    break;

                case ("-"):
                    result = num01 - num02;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n");
                    Console.WriteLine("The answer is " + result);
                    break;

                case ("*"):
                    result = num01 * num02;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n");
                    Console.WriteLine("The answer is " + result);
                    break;

                case ("/"):
                    result = num01 / num02;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n");
                    Console.WriteLine("The answer is " + result);
                    break;
            }
        }
    }
}
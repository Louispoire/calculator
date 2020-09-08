using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab_LouisPhilippeSimard_CristianCantillo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            bool keepTheLoopAlive = false;
            String choice;
            String operand;

            while (keepTheLoopAlive == false)
            {
                Console.WriteLine("Welcome to Calculator V1.05!");
                Console.WriteLine("Please enter Number #1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Number #2");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an operation");
                Console.WriteLine("A: Add");
                Console.WriteLine("M: Multiple");
                Console.WriteLine("S: Subtract");
                Console.WriteLine("D: Divide");
                operand = Console.ReadLine();
                while (operand.ToLower() != "a" && operand.ToLower() != "d" && operand.ToLower() != "m" && operand.ToLower() != "s")
                {
                    if (operand.ToLower() != "a" && operand.ToLower() != "d" && operand.ToLower() != "m" && operand.ToLower() != "s")
                    {
                        Console.WriteLine("Please enter one of these letters!");
                        operand = Console.ReadLine();
                    }
                }
                if (operand.ToLower() == "a")
                {
                    Console.WriteLine($"Results: {num1 + num2}");

                }
                if (operand.ToLower() == "m")
                {
                    Console.WriteLine($"Results: {num1 * num2}");

                }
                if (operand.ToLower() == "s")
                {
                    Console.WriteLine($"Results: {num1 - num2}");

                }
                if (operand.ToLower() == "d")
                {
                    Console.WriteLine($"Results: {num1 / num2}");
                }
                Console.WriteLine("Thank you for using Calculator V1.05!");
                Console.WriteLine("Y/N End program?");
                choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    continue;
                }
                if (choice.ToLower() == "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please Y or N. Thank you!");
                    choice = Console.ReadLine();
                    continue;
                }
            }
        }
    }
}

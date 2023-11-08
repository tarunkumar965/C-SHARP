using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Calculator Menu:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Quit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 5)
                    {
                        break;
                    }
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = 0;
                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            break;
                        case 2:
                            result = num1 - num2;
                            break;
                        case 3:
                            result = num1 * num2;
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Division by zero is not allowed.");
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid operation.");
                            continue;
                    }
                    Console.WriteLine("Result: " + result);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter valid numeric values.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
            }
        }
    }
}

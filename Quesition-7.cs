using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the dividend: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    if (divisor == 0)
                    {
                        throw new DivideByZeroException("Division can't be Zero!!.");
                    }
                    double result = (double) dividend / divisor;
                    Console.WriteLine("Result of division: " + result);
                    break;
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

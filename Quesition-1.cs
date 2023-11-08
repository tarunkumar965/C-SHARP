using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Dividend: ");
                int dividend = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception handled: " + ex.Message);
            }
        }
    }
}

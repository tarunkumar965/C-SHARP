using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideByZeroMethod();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught and handled exception: " + ex.Message);
            }
        }

        static void DivideByZeroMethod()
        {
            try
            {
                int dividend = 10;
                int divisor = 0;
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Outer Try Block");
                try
                {
                    Console.WriteLine("Inner Try Block");
                    throw new Exception("Inner Exception");
                }
                catch (Exception innerExMessage)
                {
                    Console.WriteLine("Inner Catch Block: " + innerExMessage.Message);
                }
                //Here First Inner block exception is Handled and after that the outer exception is handled.
                Console.WriteLine("After Inner Try-Catch");
                throw new Exception("Inner Exception");
            }
            catch (Exception outerEx)
            {
                Console.WriteLine("Outer Catch Block: " + outerEx.Message);
            }
            Console.WriteLine("After Outer Try-Catch");
        }
    }
}

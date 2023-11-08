using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques4
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) 
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -5;
                if (age < 0)
                {
                    throw new CustomException("Age cannot be negative.");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom exception handled: " + ex.Message);
            }
        }
    }
}

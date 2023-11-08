using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "abc";
                int value = Convert.ToInt32(input);
                Console.WriteLine("Value: " + value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception handled: " + ex.Message);
            }
        }
    }
}

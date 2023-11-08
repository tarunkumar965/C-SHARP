using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                int value = arr[5];
                Console.WriteLine("Value: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception handled: " + ex.Message);
            }
        }
    }
}

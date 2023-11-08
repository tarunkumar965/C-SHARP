using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                int value = arr[5];
                int result = Convert.ToInt32("abc");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int x = a / b;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception handled: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception handled: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception handled: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception handled: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass5_Ques10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxAllowedPrice = 10000;
            int[] shoppingCart = new int[10];
            int itemCount = 0;
            int totalPrice = 0;
            Console.WriteLine("Welcome to the shopping cart!");
            Console.WriteLine("Please enter the price of items (enter a negative price to finish):");
            while (true)
            {
                try
                {
                    Console.Write("Item " + (itemCount + 1) + ": $");
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please enter a valid price.");
                        continue;
                    }
                    int price = int.Parse(input);
                    if (price < 0)
                    {
                        throw new NegativePriceException();
                    }
                    if (price > maxAllowedPrice)
                    {
                        throw new PriceTooHighException();
                    }
                    shoppingCart[itemCount] = price;
                    totalPrice += price;
                    itemCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input: Please enter a valid price.");
                }
                catch (NegativePriceException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                catch (PriceTooHighException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input: Price value is too high.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred: " + ex.Message);
                }
                if (itemCount >= shoppingCart.Length || totalPrice >= maxAllowedPrice)
                {
                    break;
                }
            }
            Console.WriteLine("Items in your shopping cart:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine("Item " + (i + 1) + ": $" + shoppingCart[i]);
            }
            Console.WriteLine("Total Price: $" + totalPrice);
        }
    }
    class NegativePriceException : Exception
    {
        public NegativePriceException() : base("Invalid price: Price cannot be negative.") 
        { 
        }
    }

    class PriceTooHighException : Exception
    {
        public PriceTooHighException() : base("Invalid price: Price exceeds the maximum allowed.") 
        { 
        }
    }
}

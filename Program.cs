using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> {55, 42, 23, 60, 42, 20, 52, 6004};
                Console.WriteLine("We have a list of numbers!\nPlease enter a number to divide each list item by:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int x in numbers)
                {
                int  result = x / divisor;
                Console.WriteLine(x + " divided by " +divisor+ " equals " + result);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nWe have exited the try/catch block!");
                Console.ReadLine();
            }
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " is " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
        }
    }
}

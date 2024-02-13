using System.Collections.Generic;
using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
        
            Console.WriteLine("How long is the list of numbers:\n");

            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput a Number (Press enter to submit):\n");

        double[] AvArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                 AvArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            double result;
            result = AvArray.Sum() / AvArray.Length;

            Console.WriteLine("\nThe result is " + result);
            // Wait before closing
            Console.ReadKey();
        }
    }
}

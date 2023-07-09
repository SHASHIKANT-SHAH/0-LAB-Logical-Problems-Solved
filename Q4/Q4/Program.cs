
//write a program  to print Nth fibonacci number in series


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the value of N to find the Nth Fibonacci number: ");
            int n = int.Parse(Console.ReadLine());

            int fibN = Fibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {fibN}");
            Console.ReadLine();
        }
        public static int Fibonacci(int n)
        {
            // Handle the base cases
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            // Initialize the first two numbers in the series
            int fibNMinus2 = 0;
            int fibNMinus1 = 1;

            // Calculate the Nth Fibonacci number
            int fibN = 0;
            for (int i = 2; i <= n; i++)
            {
                fibN = fibNMinus2 + fibNMinus1;
                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            return fibN;
        }
    }
}

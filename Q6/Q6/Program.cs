//Here 's an example program in C# that calculates the power of a number using tail recursion:
using System;
namespace Q6
{
    internal class Program
    {
        public static int Power(int baseNum, int exponent, int result = 1)
        {
            if (exponent == 0)
            {
                return result;
            }
            else
            {
                return Power(baseNum, exponent - 1, result * baseNum);
            }
        }
        static void Main(string[] args)
        {
            int baseNum = 2;
            int exponent = 5;
            int result = Power(baseNum, exponent);

            Console.WriteLine($"{baseNum}^{exponent} = {result}");
            Console.ReadLine();
        }
    }
}

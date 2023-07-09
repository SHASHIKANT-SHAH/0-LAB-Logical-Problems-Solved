
//given an array of integers, write a C# method to total all the values that are even numbers

using System;
namespace Q1
{
    public class Q1
    {
        public static int TotalEvenNum(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
            }
            return total;
        }

        
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total = TotalEvenNum(numbers);
            Console.WriteLine(total);
            
            Console.ReadLine();

        }
    }
}

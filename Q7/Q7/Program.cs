
//Write a program to iterate through Enum values in C#? public enum Colors{red,blue,green, yellow}

using System;

namespace Q7
{
    public enum Colors
    {
        red,
        blue,
        green,
        yellow
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color);
            }

            Console.ReadLine();
        }
    }
}

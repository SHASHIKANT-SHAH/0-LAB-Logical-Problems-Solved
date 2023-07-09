//write an over loaded funtion in c# to calculate an area of a square or a rectangel.

using System;

namespace Q8
{
    internal class Program
    {
        public class AreaCalculator
        {
            public double CalculateArea(double sLength)
            {
                return sLength * sLength; //area of a square
            }
            public double CalculateArea(double length, double width)
            {
                return length * width; // area of a rectangle
            }
        }
        static void Main(string[] args)
        {
            AreaCalculator calculator = new AreaCalculator();
            double squareArea = calculator.CalculateArea(5);
            double rectangleArea = calculator.CalculateArea(5, 10);
            Console.WriteLine(squareArea);
            Console.WriteLine(rectangleArea);
            Console.ReadLine();
        }
    }
}

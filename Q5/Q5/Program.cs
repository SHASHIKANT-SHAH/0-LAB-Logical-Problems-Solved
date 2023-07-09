
//give an instance circle of the following class of circle

using System;


namespace Q5
{

    internal class Program
    {
        public sealed class Circle
        {
            public double radius;

            public double Calculate(Func<double, double> op)
            {
                return op(radius);
            }

            public double CalculateCircumference()
            {
                return Calculate(r => 2 * Math.PI * r);
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 5;
            double circumference = circle.CalculateCircumference();
            Console.WriteLine("Circumference of the circle is: {0}", circumference);
            Console.ReadKey();
        }
    }
}

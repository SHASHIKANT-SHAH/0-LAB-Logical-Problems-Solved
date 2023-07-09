using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class demo
    {
        public demo() {
            Console.WriteLine("hello");
        }
    }
    public class demo2 : demo
    {
        public demo2()
        {
            Console.WriteLine("hello2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo2 d = new demo2();
            Console.Read();
        }
    }
}

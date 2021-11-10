using LearnProxy.Classes;
using System;

namespace LearnProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();
            // Do the math
            Console.WriteLine("Input x");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input y");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x + y = " + proxy.Add(x, y));
            Console.WriteLine("x - y = " + proxy.Sub(x, y));
            Console.WriteLine("x * y = " + proxy.Mul(x, y));
            Console.WriteLine("x / y = " + proxy.Div(x, y));
            // Wait for user
            
        }
    }
}

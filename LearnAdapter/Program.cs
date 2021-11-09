using LearnAdapter.Classes;
using LearnAdapter.Interfaces;
using System;

namespace LearnAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            
            
            Console.WriteLine("This is adaptee1:");
            Console.WriteLine($" { target.GetRequest()} with color {target.Color()} ");

            
           
            Console.WriteLine("This is adaptee2:");
            Adaptee2 adaptee2 = new Adaptee2();
            ITarget target1 = new Adapter2(adaptee2);
            
            Console.WriteLine($" { target1.GetRequest()} with color {target1.Color()} ");
            
        }
    }
}

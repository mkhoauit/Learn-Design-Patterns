using LearnBuilder.Classes;
using System;

namespace LearnBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var client = new Client();
            var barber = new Barber();
                
            client.Barber = barber;

            Console.WriteLine("Standard basic service:");
            client.NormalService();
            Console.WriteLine(barber.GetService().ListService());

            Console.WriteLine("Standard full service:");
            client.FullService();
            Console.WriteLine(barber.GetService().ListService());

            // Remember, the Barber pattern can be used without a Client
            // class.
            Console.WriteLine("Custom Service:");
            barber.CleanEar();
            barber.ShaveBeard();
            Console.Write(barber.GetService().ListService());
            
        }
    }
}

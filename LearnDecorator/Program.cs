using LearnDecorator.Classes;
using System;

namespace LearnDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var tomato = new TomatoPizza();
            Console.WriteLine("Client: I get a tomato pizza");
            client.ClientCode(tomato);
            Console.WriteLine();

            var chicken = new ChickenPizza();
            Console.WriteLine("Client: I get a chicken pizza");
            client.ClientCode(chicken);
            Console.WriteLine();
            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            ChesseDecorator decorator1 = new ChesseDecorator(tomato);
            PepperDecorator decorator2 = new PepperDecorator(decorator1);
            Console.WriteLine("Client (Max): Now I've got a decorated pizza:");
            client.ClientCode(decorator2);
            Console.WriteLine("");
            PepperDecorator pepperDecorator = new PepperDecorator(chicken);
            Console.WriteLine("Client (Min): Now I've got a decorated pizza:");
            client.ClientCode(pepperDecorator);


        }
    }
}

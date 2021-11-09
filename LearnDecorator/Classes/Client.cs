using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDecorator.Classes
{
    class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ClientCode(APizza pizza)
        {
            Console.WriteLine("Client order: " + pizza.doPizza());
        }
    }
}

using LearnObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserver.Classes
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 )
            {
                Console.WriteLine("ConcreteObserverB: Iphone 13 available.");
            }
            else
            {
                if ((subject as Subject).State >= 3) 
                {
                    Console.WriteLine("ConcreteObserverB: Discount 20% Iphone 12 ");

                }

            }
        }
    }
}

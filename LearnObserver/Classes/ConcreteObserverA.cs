using LearnObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserver.Classes
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            switch ((subject as Subject).State)
            { 
            case 1:            
                    Console.WriteLine("ConcreteObserverA: Discount 50% Iphone 6");
                break;
                case 2:
                    Console.WriteLine("ConcreteObserverA: Disount 20% LapTop DEL");
                    break;
            }
            
        }
    }
}

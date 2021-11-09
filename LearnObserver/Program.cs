using LearnObserver.Classes;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LearnObserver
{
  
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
           
            subject.Attach(observerA);Console.Write("A");
            Console.WriteLine("");

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);Console.Write("B");
            Console.WriteLine("");

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            Console.WriteLine("");

            subject.Detach(observerB); Console.Write("B");
            Console.WriteLine("");

            subject.SomeBusinessLogic();
        }
    }
}

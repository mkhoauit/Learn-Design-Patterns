﻿using LearnObserver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnObserver.Classes
{
    public class Subject : ISubject
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            Console.Write("Subject: Attached (add) an observer ");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)  
        {
            this._observers.Remove(observer);
            Console.Write("Subject: Detached (remove) an observer ");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            Parallel.ForEach(_observers, i => i.Update(this));
            
        }
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 5);

            Thread.Sleep(10);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }


}

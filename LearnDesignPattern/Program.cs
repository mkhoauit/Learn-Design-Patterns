using LearnDesignPattern.Classes;
using LearnDesignPattern.Interfaces;
using System;

namespace LearnDesignPattern
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    
//LearnFactory
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
           
            
        }
    }
}

using LearnAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAdapter.Classes
{
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
      

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
       
        public string Color()
        {
           
            
            return $"red";
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
       
    }
}

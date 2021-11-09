using LearnAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAdapter.Classes
{
    class Adapter2 : ITarget
    {
        private readonly Adaptee2 _adaptee;


        public Adapter2(Adaptee2 adaptee2)
        {
            _adaptee = adaptee2;
        }

        public string Color()
        {
            return _adaptee.GetColor();

           
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }

    }
}

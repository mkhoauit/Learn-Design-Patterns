using LearnDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPattern.Classes
{
    /// <summary>
    /// chuc nang cua san pham A2 (Ao thun)
    /// </summary>
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "Ao thun kieu moi.";
        }
    }
}

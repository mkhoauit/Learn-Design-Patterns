using LearnDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDesignPattern.Classes
{
    /// <summary>
    /// chuc nang cua san pham A1 (kem danh rang PS) 
    /// </summary>
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "Kem danh rang PS.";
        }
    }
}

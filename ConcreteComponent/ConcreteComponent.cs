using DecoratorDesgAssignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesgAssignment.ConcreteComponent
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hello, its me Sushan.";
        }
    }
}

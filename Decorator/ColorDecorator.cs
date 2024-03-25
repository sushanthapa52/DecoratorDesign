using DecoratorDesgAssignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesgAssignment.Decorator
{
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component) { }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m";
     
        }
    }
}

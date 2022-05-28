using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class DecoratorA : IComponent
    {
        IComponent component;

        internal DecoratorA(IComponent c)
        {
            this.component = c;
        }
        public string Operation()
        {
            string s = component.Operation();
            s += "and listening to Classic FM ";
            return s;
        }
    }



}


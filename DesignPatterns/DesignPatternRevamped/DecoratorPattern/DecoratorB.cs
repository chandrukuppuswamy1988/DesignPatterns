using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class DecoratorB : IComponent
    {
        IComponent component;
        public string addedState = "past the Coffee Shop ";

        internal DecoratorB(IComponent c)
        {
            this.component = c;
        }

        public string Operation()
        {
            string s = component.Operation();
            s += "to school ";
            return s;
        }

        public string AddedBehavior()
        {
            return "and I bought a cappuccino ";
        }


    }
}

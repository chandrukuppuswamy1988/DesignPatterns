using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class ClassB : IPrimitives
    {
        public string Operation1()
        {
            return "ClassB:Op1 ";
        }
        public string Operation2()
        {
            return "ClassB.Op2 ";
        }
    }
}

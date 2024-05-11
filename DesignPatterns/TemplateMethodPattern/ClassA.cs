﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class ClassA : IPrimitives
    {
        public string Operation1()
        {
            return "ClassA:Op1 ";
        }
        public string Operation2()
        {
            return "ClassA:Op2 ";
        }
    }


}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }


}

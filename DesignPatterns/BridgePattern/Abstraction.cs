﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Abstraction
    {
        Bridge bridge;
        public Abstraction(Bridge implementation)
        {
            bridge = implementation;
        }
        public string Operation()
        {
          return "Abstraction" + " <<< BRIDGE >>>> " + bridge.OperationImp();
        }
    }
 
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ProductA : IProduct
    {
        public String ShipFrom()
        {
            return " from South Africa";
        }
    }


}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Creator
    {
        public IProduct FactoryMethod(int month)
        {
            if (month >= 4 && month <= 11)
                return new ProductA();
            else
                 if (month == 1 || month == 2 || month == 12)
                return new ProductB();
            else return new DefaultProduct();
        }
    }


}

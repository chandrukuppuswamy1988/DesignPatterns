﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface IFactory<Brand>
              where Brand : IBrand 
    {
            IBag CreateBag();
             IShoes CreateShoes();
    }

}

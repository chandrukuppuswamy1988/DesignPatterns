using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Shoes<Brand> : IShoes
         where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {
            myBrand = new Brand();
        }

        public int Price { get { return myBrand.Price; } }
    }




}

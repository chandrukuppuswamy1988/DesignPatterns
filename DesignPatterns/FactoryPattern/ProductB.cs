using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ProductB : IProduct
    {
        public String ShipFrom()
        {
            return "from Spain";
        }
    }


}

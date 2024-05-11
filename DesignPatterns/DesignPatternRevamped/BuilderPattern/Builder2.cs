using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Builder2 : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.Add("PartX ");
        }

        public void BuildPartB()
        {
            product.Add("PartY ");
        }

        public Product GetResult()
        {
            return product;
        }
    }


}

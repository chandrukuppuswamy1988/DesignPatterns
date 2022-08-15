using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Builder1 : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.Add("PartA ");
        }

        public void BuildPartB()
        {
            product.Add("PartB ");
        }

        public Product GetResult()
        {
            return product;

        }
    }
}

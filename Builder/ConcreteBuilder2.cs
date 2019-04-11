using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.PartA = "2 Create PartA";
        }

        public override void BuildPartB()
        {
            product.PartB = "2 Create PartB";
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

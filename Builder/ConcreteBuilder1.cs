using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //实现Builder的接口以构造和装配该产品的各个部件。 
    //定义并明确它所创建的表示。 
    //提供一个检索产品的接口
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.PartA = "1 Create PartA";
        }

        public override void BuildPartB()
        {
            product.PartB = "1 Create PartB";
        }

        public override Product GetResult()
        {
            return product;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //表示被构造的复杂对象。ConcreteBuilder创建该产品的内部表示并定义它的装配过程。 
    //包含定义组成部件的类，包括将这些部件装配成最终产品的接口。 
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
    }
}

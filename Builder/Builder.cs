using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //为创建一个Product对象的各个部件指定抽象接口。 
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}

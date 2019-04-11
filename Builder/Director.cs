using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{   
    //构造一个使用Builder接口的对象。 
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}

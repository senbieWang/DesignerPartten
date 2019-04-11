using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Application
    {
       public abstract Document CreateDocument();  //工厂方法
    }

    public  class TxtApplication : Application
    {     
        public override Document CreateDocument()
        {
            return new TxtDocument();
        }
    }

    public class WordApplication : Application
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}

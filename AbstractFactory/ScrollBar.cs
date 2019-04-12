using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ScrollBar
    {
        public abstract void showBar();
        
    }

    public class PMScrollBar : ScrollBar
    {
        public override void showBar()
        {
            Console.WriteLine("PMScrollBar show");
        }
    }

    public class MotifScrollBar : ScrollBar
    {
        public override void showBar()
        {
            Console.WriteLine("MotifScrollBar show");
        }
    }

}

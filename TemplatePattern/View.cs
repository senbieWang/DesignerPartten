using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public  class View
    {
        public void Display()
        {
            SetFocus();
            DoDisplay();
            ResetFocus();
        }

        protected void SetFocus()
        {
            Console.WriteLine("set focus.");
        }

        protected virtual void DoDisplay() { }  //钩子，我来找你（好莱坞法则），父类调用子类

        protected void ResetFocus()
        {
            Console.WriteLine("Reset focus.");
        }

    }

    public class MyView : View
    {
        protected override void DoDisplay()
        {
            Console.WriteLine("MyView display.");
        }
    }

}

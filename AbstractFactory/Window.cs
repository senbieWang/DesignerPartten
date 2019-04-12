using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Window
    {
        public abstract void showWindow();
    }

    public class PMWindow : Window
    {
        public override void showWindow()
        {
            Console.WriteLine("PMWindow show");
        }
    }
    public class MotifWindow : Window
    {
        public override void showWindow()
        {
            Console.WriteLine("MotifWindow show");
        }
    }

}

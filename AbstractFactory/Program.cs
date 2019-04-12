using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WidgetFactory widgetFactory = new PMWidgetFactory();
            widgetFactory.CreateScrollBar().showBar();
            widgetFactory.CreateWindow().showWindow();

            widgetFactory = new MotifFactory();
            widgetFactory.CreateScrollBar().showBar();
            widgetFactory.CreateWindow().showWindow();

        }
    }
}

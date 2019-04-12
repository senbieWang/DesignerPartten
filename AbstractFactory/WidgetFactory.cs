using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class WidgetFactory
    {
        public abstract ScrollBar CreateScrollBar();
        public abstract Window CreateWindow();
    }

    public class PMWidgetFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new PMScrollBar();
        }

        public override Window CreateWindow()
        {
            return new PMWindow();
        }
    }

    public class MotifFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }

        public override Window CreateWindow()
        {
            return new MotifWindow();
        }
    }
}

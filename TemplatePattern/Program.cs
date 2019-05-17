using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new MyView();
            view.Display();
        }
    }
}

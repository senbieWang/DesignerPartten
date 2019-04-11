using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Document
    {
        public abstract void Open();
        public abstract void Close();
        public abstract void Save();
        public abstract void Revert();
    }

    public class TxtDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine("Close Text");
        }

        public override void Open()
        {
            Console.WriteLine("Open Text");
        }

        public override void Revert()
        {
            Console.WriteLine("Revert Text");
        }

        public override void Save()
        {
            Console.WriteLine("Save Text");
        }
    }

    public class WordDocument : Document
    {
        public override void Close()
        {
            Console.WriteLine("Close Word");
        }

        public override void Open()
        {
            Console.WriteLine("Open Word");
        }

        public override void Revert()
        {
            Console.WriteLine("Revert Word");
        }

        public override void Save()
        {
            Console.WriteLine("Save Word");
        }
    }

}

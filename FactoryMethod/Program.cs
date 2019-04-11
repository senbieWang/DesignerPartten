using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new TxtApplication();
            var doc = application.CreateDocument();
            doc.Open();
            doc.Revert();
            doc.Save();
            doc.Close();

            application = new WordApplication();
            doc = application.CreateDocument();
            doc.Open();
            doc.Revert();
            doc.Save();
            doc.Close();

        }
    }
}

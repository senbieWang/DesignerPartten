using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder1(); 
            Director director = new Director();
            director.Construct(builder);
            Console.WriteLine(builder.GetResult().PartA);
            Console.WriteLine(builder.GetResult().PartB);

            builder = new ConcreteBuilder2();
            director.Construct(builder);
            Console.WriteLine(builder.GetResult().PartA);
            Console.WriteLine(builder.GetResult().PartB);

        }
    }
}

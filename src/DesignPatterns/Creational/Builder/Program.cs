namespace Builder
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            var product1 = b1.GetResult();
            product1.Show();

            Console.WriteLine();

            director.Construct(b2);
            var product2 = b2.GetResult();
            product2.Show();

            Console.ReadKey();
        }
    }
}
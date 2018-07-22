namespace AbstractFactory
{
    using System;

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            Console.WriteLine("ConcreteFactory2 create ProductA2");
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            Console.WriteLine("ConcreteFactory2 create ProductB2");
            return new ProductB2();
        }
    }
}
namespace AbstractFactory
{
    using System;

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            Console.WriteLine("ConcreteFactory1 create ProductA1");
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            Console.WriteLine("ConcreteFactory1 create ProductB1");
            return new ProductB1();
        }
    }
}
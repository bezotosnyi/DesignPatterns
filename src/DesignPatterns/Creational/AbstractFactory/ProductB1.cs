namespace AbstractFactory
{
    using System;

    public class ProductB1 : AbstractProductB
    {
        public ProductB1()
        {
            Console.WriteLine("Instance ProductB1");
        }

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                              " interacts with " + a.GetType().Name);
        }
    }
}
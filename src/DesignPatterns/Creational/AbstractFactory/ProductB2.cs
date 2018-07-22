namespace AbstractFactory
{
    using System;

    public class ProductB2 : AbstractProductB
    {
        public ProductB2()
        {
            Console.WriteLine("Instance ProductB2");
        }

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                              " interacts with " + a.GetType().Name);
        }
    }
}
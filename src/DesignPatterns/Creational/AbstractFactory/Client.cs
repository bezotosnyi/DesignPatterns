namespace AbstractFactory
{
    public class Client
    {
        private readonly AbstractProductA abstractProductA;

        private readonly AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            this.abstractProductA = factory.CreateProductA();
            this.abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}
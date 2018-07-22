namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            this.product.Add("PartX");
        }

        public override void BuildPartB()
        {
            this.product.Add("PartY");
        }

        public override Product GetResult()
        {
            return this.product;
        }
    }
}
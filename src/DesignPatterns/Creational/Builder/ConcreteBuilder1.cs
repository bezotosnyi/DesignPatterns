namespace Builder
{
    public class ConcreteBuilder1 : Builder
    {
        private readonly Product product = new Product();

        public override void BuildPartA()
        {
            this.product.Add("PartA");
        }

        public override void BuildPartB()
        {
            this.product.Add("PartB");
        }

        public override Product GetResult()
        {
            return this.product;
        }
    }
}
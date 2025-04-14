namespace NetFundamentals.DesignPatterns.Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.PartA = "PartA2";
        }

        public override void BuildPartB()
        {
            product.PartB = "PartB2";
        }

        public override void BuildPartC()
        {
            product.PartC = "PartC2";
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

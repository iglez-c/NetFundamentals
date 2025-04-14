namespace NetFundamentals.DesignPatterns.Builder
{
    // ConcreteBuilder classes implement the Builder to build a specific type of Product.
    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.PartA = "PartA1";
        }

        public override void BuildPartB()
        {
            product.PartB = "PartB1";
        }

        public override void BuildPartC()
        {
            product.PartC = "PartC1";
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

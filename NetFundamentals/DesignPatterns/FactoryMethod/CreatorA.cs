namespace NetFundamentals.DesignPatterns.FactoryMethod
{
    public class CreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductA();
        }
    }
}

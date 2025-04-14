namespace NetFundamentals.DesignPatterns.FactoryMethod
{
    public class CreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}

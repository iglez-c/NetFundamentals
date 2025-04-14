namespace NetFundamentals.DesignPatterns.FactoryMethod
{
    // The Factory Method pattern defines an interface for creating objects, but lets subclasses decide which class to instantiate.
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }
}

namespace NetFundamentals.DesignPatterns.AbstractFactory
{
    // The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}

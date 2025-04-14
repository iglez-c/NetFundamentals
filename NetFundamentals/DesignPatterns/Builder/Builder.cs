namespace NetFundamentals.DesignPatterns.Builder
{
    // The Builder abstract class specifies the methods for building each part of the Product.
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }
}

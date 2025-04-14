namespace NetFundamentals.DesignPatterns.Builder
{
    // The Director class is responsible for managing the Builder and building the Product.
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}

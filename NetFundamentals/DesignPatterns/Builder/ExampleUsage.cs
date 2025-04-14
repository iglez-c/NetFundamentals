using System;

namespace NetFundamentals.DesignPatterns.Builder
{
    public class ExampleUsage
    {
        /// <summary>
        /// In this example, the Product is a class with three properties: PartA, PartB, and PartC.
        /// The Builder is an abstract class with four methods: BuildPartA, BuildPartB, BuildPartC, and GetResult.
        /// ConcreteBuilder classes implement the Builder to build a specific type of Product.
        /// The Director class is responsible for managing the Builder and building the Product.
        /// Finally, in the example usage, two Products are created using two different ConcreteBuilders, and the parts of each Product are printed to the console.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("--==== Builder ====--");

            // Create a Director object
            Director director = new Director();

            // Create a ConcreteBuilder1 object and pass it to the Director
            ConcreteBuilder1 builder1 = new ConcreteBuilder1();
            director.Construct(builder1);

            // Get the Product from the Builder
            Product product1 = builder1.GetResult();

            // Create a ConcreteBuilder2 object and pass it to the Director
            ConcreteBuilder2 builder2 = new ConcreteBuilder2();
            director.Construct(builder2);

            // Get the Product from the Builder
            Product product2 = builder2.GetResult();

            // Print the parts of the Products
            Console.WriteLine("Product 1 Parts: {0}, {1}, {2}", product1.PartA, product1.PartB, product1.PartC);
            Console.WriteLine("Product 2 Parts: {0}, {1}, {2}", product2.PartA, product2.PartB, product2.PartC);
        }
    }
}

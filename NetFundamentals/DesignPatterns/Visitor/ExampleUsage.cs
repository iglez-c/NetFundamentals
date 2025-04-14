using System;
using System.Collections.Generic;

namespace NetFundamentals.DesignPatterns.Visitor
{
    /// <summary>
    /// In this example, we have two concrete elements (Book and Fruit) that implement the IElement interface.
    /// Each element also implements an Accept method that takes a IVisitor object as a parameter.
    ///
    /// We also have a ShoppingCartVisitor class that implements the IVisitor interface.
    /// This visitor calculates the total price of all the elements it visits, according to their respective prices or price per kg and weight.
    ///
    /// In the Main method, we create a list of IElement objects that contains both books and fruits.
    /// We then create a ShoppingCartVisitor object and iterate over the list of elements,
    /// calling the Accept method on each element and passing the ShoppingCartVisitor object as a parameter.
    /// Finally, we print out the total price calculated by the visitor.
    /// </summary>
    public class ExampleUsage
    {
        // The client
        public void Execute()
        {
            Console.WriteLine("--==== Visitor ====--");

            List<IElement> items = new List<IElement>
            {
                new Book("Design Patterns", 25.0),
                new Fruit("Banana", 0.99, 0.5),
                new Fruit("Apple", 1.49, 0.3)
            };

            var visitor = new ShoppingCartVisitor();
            foreach (var item in items)
            {
                item.Accept(visitor);
            }

            Console.WriteLine($"Total price: {visitor.TotalPrice:C}");
        }
    }
}

using System;

namespace NetFundamentals.DesignPatterns.Strategy
{
    /// <summary>
    /// In this example, we have a ShippingContext class that takes an IShippingStrategy object as a parameter in its constructor.
    /// This IShippingStrategy interface defines the CalculateShippingCost method that calculates the cost of shipping a package based on its weight and distance.
    ///
    /// We have two concrete strategy classes, StandardShippingStrategy and ExpeditedShippingStrategy,
    /// which implement the IShippingStrategy interface and provide their own implementations of the CalculateShippingCost method.
    ///
    /// In the ShippingContext class, the CalculateShippingCost method delegates the calculation of the shipping cost to the
    /// CalculateShippingCost method of the currently set IShippingStrategy object.
    ///
    /// In the Main method of the Program class, we create a ShippingContext object with a StandardShippingStrategy and calculate the
    /// cost of shipping a 10 lb package 100 miles using this strategy.
    /// We then change the shipping strategy to ExpeditedShippingStrategy and calculate the cost of shipping the same package using this strategy.
    /// </summary>
    public class ExampleUsage
    {
        public void Execute()
        {
            Console.WriteLine("--==== Strategy ====--");
            
            // Create a shipping context with a standard shipping strategy
            var shippingContext = new ShippingContext(new StandardShippingStrategy());

            // Calculate the cost of shipping a 10 lb package 100 miles using the standard shipping strategy
            double standardShippingCost = shippingContext.CalculateShippingCost(10, 100);
            Console.WriteLine($"Standard shipping cost: {standardShippingCost}");

            // Change the shipping strategy to expedited
            shippingContext.SetShippingStrategy(new ExpeditedShippingStrategy());

            // Calculate the cost of shipping a 10 lb package 100 miles using the expedited shipping strategy
            double expeditedShippingCost = shippingContext.CalculateShippingCost(10, 100);
            Console.WriteLine($"Expedited shipping cost: {expeditedShippingCost}");
        }
    }
}

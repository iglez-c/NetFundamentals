namespace NetFundamentals.DesignPatterns.Strategy
{
    // Concrete strategies
    public class StandardShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight, double distance)
        {
            return 0.05 * weight * distance;
        }
    }
}

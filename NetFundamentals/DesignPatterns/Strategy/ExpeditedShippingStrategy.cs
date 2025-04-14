namespace NetFundamentals.DesignPatterns.Strategy
{
    public class ExpeditedShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight, double distance)
        {
            return 0.1 * weight * distance;
        }
    }
}

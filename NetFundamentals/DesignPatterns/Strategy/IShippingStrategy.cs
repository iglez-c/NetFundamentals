namespace NetFundamentals.DesignPatterns.Strategy
{
    // Strategy interface
    public interface IShippingStrategy
    {
        double CalculateShippingCost(double weight, double distance);
    }
}

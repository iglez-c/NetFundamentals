namespace NetFundamentals.DesignPatterns.Strategy
{
    public class ShippingContext
    {
        private IShippingStrategy _shippingStrategy;

        public ShippingContext(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(double weight, double distance)
        {
            return _shippingStrategy.CalculateShippingCost(weight, distance);
        }
    }
}

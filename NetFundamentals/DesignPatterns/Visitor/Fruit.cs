namespace NetFundamentals.DesignPatterns.Visitor
{
    public class Fruit : IElement
    {
        public string Name { get; set; }
        public double PricePerKg { get; set; }
        public double Weight { get; set; }

        public Fruit(string name, double pricePerKg, double weight)
        {
            Name = name;
            PricePerKg = pricePerKg;
            Weight = weight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

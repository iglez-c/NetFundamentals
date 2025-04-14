namespace NetFundamentals.DesignPatterns.Visitor
{
    // Concrete visitor
    public class ShoppingCartVisitor : IVisitor
    {
        public double TotalPrice { get; private set; }

        public void Visit(Book book)
        {
            TotalPrice += book.Price;
        }

        public void Visit(Fruit fruit)
        {
            TotalPrice += fruit.PricePerKg * fruit.Weight;
        }
    }
}

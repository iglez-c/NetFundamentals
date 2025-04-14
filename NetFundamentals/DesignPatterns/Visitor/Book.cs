namespace NetFundamentals.DesignPatterns.Visitor
{
    // Concrete elements
    public class Book : IElement
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

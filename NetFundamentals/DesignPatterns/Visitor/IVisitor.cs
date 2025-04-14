namespace NetFundamentals.DesignPatterns.Visitor
{
    // The visitor interface
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}

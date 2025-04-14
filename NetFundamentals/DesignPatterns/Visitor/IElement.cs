namespace NetFundamentals.DesignPatterns.Visitor
{
    // The element interface
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

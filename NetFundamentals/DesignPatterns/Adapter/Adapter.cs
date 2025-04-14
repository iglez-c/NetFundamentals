namespace NetFundamentals.DesignPatterns.Adapter
{
    // The Adapter class adapts the Adaptee to the Target interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}

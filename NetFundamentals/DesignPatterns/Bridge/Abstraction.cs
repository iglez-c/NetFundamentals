namespace NetFundamentals.DesignPatterns.Bridge
{
    // The Abstraction class defines the interface for the Abstraction part of the bridge.
    public abstract class Abstraction
    {
        protected IImplementor implementor;

        public Abstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Operation();
    }
}

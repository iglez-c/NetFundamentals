namespace NetFundamentals.DesignPatterns.Decorator
{
    // The Decorator abstract class maintains a reference to a Component object and defines an interface that conforms to Component's interface.
    public abstract class Decorator : Component
    {
        protected Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component.Operation();
        }
    }
}

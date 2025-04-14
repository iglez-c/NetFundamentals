namespace NetFundamentals.DesignPatterns.Composite
{
    // The Component abstract class defines the interface for all components, including leaf nodes and composite nodes.
    public abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
}

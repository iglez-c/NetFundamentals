namespace NetFundamentals.DesignPatterns.Prototype
{
    // The ConcretePrototype class implements the Prototype interface and provides a method for cloning itself.
    public class ConcretePrototype : IPrototype<ConcretePrototype>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ConcretePrototype Clone()
        {
            return (ConcretePrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}

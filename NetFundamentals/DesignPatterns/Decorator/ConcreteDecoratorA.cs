using System;

namespace NetFundamentals.DesignPatterns.Decorator
{
    // The ConcreteDecoratorA and ConcreteDecoratorB classes add responsibilities to the object dynamically.
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }

        private void AddedBehavior()
        {
            Console.WriteLine("Added behavior in ConcreteDecoratorA");
        }
    }
}

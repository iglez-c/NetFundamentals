using System;

namespace NetFundamentals.DesignPatterns.Decorator
{
    // The ConcreteComponent class represents the objects that can have responsibilities added to them dynamically.
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}

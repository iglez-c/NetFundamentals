using System;
using System.Collections.Generic;

namespace NetFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>
            {
                () => new DesignPatterns.Adapter.ExampleUsage().Execute(),
                () => new DesignPatterns.Bridge.ExampleUsage().Execute(),
                () => new DesignPatterns.Builder.ExampleUsage().Execute(),
                () => new DesignPatterns.ChainOfResponsibility.ExampleUsage().Execute(),
                () => new DesignPatterns.Command.ExampleUsage().Execute(),
                () => new DesignPatterns.Composite.ExampleUsage().Execute(),
                () => new DesignPatterns.Decorator.ExampleUsage().Execute(),
                () => new DesignPatterns.Facade.ExampleUsage().Execute(),
                () => new DesignPatterns.Flyweight.ExampleUsage().Execute(),
                () => new DesignPatterns.Interpreter.ExampleUsage().Execute(),
                () => new DesignPatterns.Iterator.ExampleUsage().Execute(),
                () => new DesignPatterns.Mediator.ExampleUsage().Execute(),
                () => new DesignPatterns.Memento.ExampleUsage().Execute(),
                () => new DesignPatterns.Observer.ExampleUsage().Execute(),
                () => new DesignPatterns.Prototype.ExampleUsage().Execute(),
                () => new DesignPatterns.Proxy.ExampleUsage().Execute(),
                () => new DesignPatterns.State.ExampleUsage().Execute(),
                () => new DesignPatterns.Strategy.ExampleUsage().Execute(),
                () => new DesignPatterns.TemplateMethod.ExampleUsage().Execute(),
                () => new DesignPatterns.Visitor.ExampleUsage().Execute(),
            };

            foreach (var action in actions)
            {
                action();
            }

            Console.ReadKey();
        }
    }
}

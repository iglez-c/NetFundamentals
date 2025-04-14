using System;
using System.Collections.Generic;

namespace NetFundamentals.DesignPatterns.Composite
{
    // The Composite class represents the composite nodes of the composite tree structure.
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + "+ " + name);

            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}

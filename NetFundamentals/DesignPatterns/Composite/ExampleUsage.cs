using System;

namespace NetFundamentals.DesignPatterns.Composite
{
    /// <summary>
    /// In this example, the Component abstract class defines the interface for all components, including leaf nodes and composite nodes.
    /// The Leaf class represents the leaf nodes of the composite tree structure, and the Composite class represents the composite nodes
    /// of the composite tree structure. The Composite class contains a List of child components, which can be either leaf nodes or composite nodes.
    /// Finally, the Client uses the Component interface to manipulate the composite tree structure by adding and removing components and
    /// displaying the structure using the Display method.
    /// </summary>
    public class ExampleUsage
    {
        // The Client uses the Component interface to manipulate the composite tree structure.
        public void Execute()
        {
            Console.WriteLine("--==== Composite ====--");
            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf 1"));
            root.Add(new Leaf("Leaf 2"));

            Composite composite = new Composite("Composite 1");
            composite.Add(new Leaf("Leaf 3"));
            composite.Add(new Leaf("Leaf 4"));
            root.Add(composite);

            root.Display(1);
        }
    }
}

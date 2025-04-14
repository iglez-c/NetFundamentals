using System;

namespace NetFundamentals.DesignPatterns.Memento
{
    /// <summary>
    /// In this example, the Originator class represents the object whose state we want to save and restore.
    /// The Memento class stores the state of the Originator object, and the Caretaker class is responsible for managing the Memento objects.
    ///
    /// When the state of the Originator changes, we create a new Memento object with the current state and save it in the Caretaker.
    /// If we later want to restore the state, we get the Memento object from the Caretaker and use it to set the state of the Originator back to its previous state.
    /// </summary>
    public class ExampleUsage
    {
        // Example usage
        public void Execute()
        {
            Console.WriteLine("--==== Memento ====--");
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            // Set the initial state of the Originator
            originator.State = "State 1";

            // Create a Memento and save it in the Caretaker
            caretaker.SetMemento(originator.CreateMemento());

            // Change the state of the Originator
            originator.State = "State 2";

            // Restore the previous state of the Originator from the Memento
            originator.SetMemento(caretaker.GetMemento());
        }
    }
}

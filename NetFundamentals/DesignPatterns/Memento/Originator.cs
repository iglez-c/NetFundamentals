using System;

namespace NetFundamentals.DesignPatterns.Memento
{
    // Originator class that creates and stores the state in a Memento object
    class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                Console.WriteLine("Setting state to " + value);
                state = value;
            }
        }

        // Creates a new Memento object with the current state
        public Memento CreateMemento()
        {
            Console.WriteLine("Creating Memento with state " + state);
            return new Memento(state);
        }

        // Restores the state from a Memento object
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state from Memento with state " + memento.GetState());
            state = memento.GetState();
        }
    }
}

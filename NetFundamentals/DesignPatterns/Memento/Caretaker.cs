using System;

namespace NetFundamentals.DesignPatterns.Memento
{
    // Caretaker class that uses the Memento to restore the state of the Originator
    class Caretaker
    {
        private Memento memento;

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Saving Memento with state " + memento.GetState());
            this.memento = memento;
        }

        public Memento GetMemento()
        {
            Console.WriteLine("Restoring Memento with state " + memento.GetState());
            return memento;
        }
    }
}

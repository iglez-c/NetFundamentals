namespace NetFundamentals.DesignPatterns.Memento
{
    // Memento class that stores the state of the Originator object
    class Memento
    {
        private readonly string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}

namespace NetFundamentals.DesignPatterns.Iterator
{
    // The ConcreteIterator class implements the Iterator interface and provides the iteration behavior for the ConcreteAggregate object.
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public bool HasNext()
        {
            return current < aggregate.Count;
        }

        public object Next()
        {
            object item = aggregate[current];
            current++;
            return item;
        }
    }
}

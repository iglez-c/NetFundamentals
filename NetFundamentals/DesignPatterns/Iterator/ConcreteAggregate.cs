using System.Collections;

namespace NetFundamentals.DesignPatterns.Iterator
{
    // The ConcreteAggregate class implements the IAggregate interface and creates an Iterator object.
    public class ConcreteAggregate : IAggregate
    {
        private ArrayList items = new ArrayList();

        public void AddItem(object item)
        {
            items.Add(item);
        }

        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
        }
    }
}

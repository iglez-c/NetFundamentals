using System.Collections.Generic;

namespace NetFundamentals.DesignPatterns.Flyweight
{
    // The FlyweightFactory class creates and manages Flyweight objects, and ensures that Flyweight objects are shared properly.
    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> flyweights = new Dictionary<string, IFlyweight>();

        public IFlyweight GetFlyweight(string key)
        {
            if (flyweights.ContainsKey(key))
            {
                return flyweights[key];
            }
            else
            {
                IFlyweight flyweight = new ConcreteFlyweight(key);
                flyweights.Add(key, flyweight);
                return flyweight;
            }
        }
    }
}

using System;

namespace NetFundamentals.DesignPatterns.Flyweight
{
    // The ConcreteFlyweight class implements the Flyweight interface and stores intrinsic state.
    public class ConcreteFlyweight : IFlyweight
    {
        private string intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            this.intrinsicState = intrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            Console.WriteLine("ConcreteFlyweight: Intrinsic State = " + intrinsicState + ", Extrinsic State = " + extrinsicState);
        }
    }
}

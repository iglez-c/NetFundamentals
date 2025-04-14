using System;

namespace NetFundamentals.DesignPatterns.Flyweight
{
    // The UnsharedConcreteFlyweight class implements the Flyweight interface and stores unshared intrinsic state.
    public class UnsharedConcreteFlyweight : IFlyweight
    {
        private string unsharedIntrinsicState;

        public UnsharedConcreteFlyweight(string unsharedIntrinsicState)
        {
            this.unsharedIntrinsicState = unsharedIntrinsicState;
        }

        public void Operation(int extrinsicState)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: Unshared Intrinsic State = " + unsharedIntrinsicState + ", Extrinsic State = " + extrinsicState);
        }
    }
}

using System;

namespace NetFundamentals.DesignPatterns.Bridge
{
    // The ConcreteImplementorA implements the Implementor interface.
    public class ConcreteImplementorA : IImplementor
    {
        public void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorA OperationImp");
        }
    }
}

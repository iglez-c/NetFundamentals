using System;

namespace NetFundamentals.DesignPatterns.Bridge
{
    // The ConcreteImplementorB implements the Implementor interface.
    public class ConcreteImplementorB : IImplementor
    {
        public void OperationImp()
        {
            Console.WriteLine("ConcreteImplementorB OperationImp");
        }
    }
}

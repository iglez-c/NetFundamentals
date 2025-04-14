using System;

namespace NetFundamentals.DesignPatterns.Facade
{
    // The Facade class provides a simple interface to the complex logic of one or more subsystems.
    public class Facade
    {
        private SubsystemA subsystemA;
        private SubsystemB subsystemB;
        private SubsystemC subsystemC;

        public Facade()
        {
            subsystemA = new SubsystemA();
            subsystemB = new SubsystemB();
            subsystemC = new SubsystemC();
        }

        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" + subsystemA.OperationA() + subsystemB.OperationB() + subsystemC.OperationC());
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" + subsystemB.OperationB() + subsystemC.OperationC());
        }
    }
}

using System;

namespace NetFundamentals.DesignPatterns.Facade
{
    /// <summary>
    /// In this example, the Facade class provides a simple interface to the complex logic of one or more subsystems.
    /// The Subsystem classes implement the functionality required by the Facade class.
    /// The Client code uses the Facade class to access the functionality of the subsystems.
    ///
    /// When the Client code calls the Operation1 method on the Facade object, the Facade object calls the OperationA,
    /// OperationB, and OperationC methods on the SubsystemA, SubsystemB, and SubsystemC objects, respectively, and returns the results as a string.
    ///
    /// When the Client code calls the Operation2 method on the Facade object, the Facade object calls the OperationB and
    /// OperationC methods on the SubsystemB and SubsystemC objects, respectively, and returns the results as a string.
    ///
    /// The Facade pattern simplifies the complexity of the subsystems by providing a simple interface to the Client code.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code uses the Facade class to access the functionality of the subsystems.
        public void Execute()
        {
            Console.WriteLine("--==== Facade ====--");
            Facade facade = new Facade();
            facade.Operation1();
            facade.Operation2();
        }
    }
}

namespace NetFundamentals.DesignPatterns.Bridge
{
    // The RefinedAbstraction class extends the Abstraction interface and delegates to the Implementor interface.
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            implementor.OperationImp();
        }
    }
}

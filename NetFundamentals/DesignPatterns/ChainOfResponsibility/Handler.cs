namespace NetFundamentals.DesignPatterns.ChainOfResponsibility
{
    // The Handler abstract class defines the interface for handling requests and provides a reference to the next handler in the chain.
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}

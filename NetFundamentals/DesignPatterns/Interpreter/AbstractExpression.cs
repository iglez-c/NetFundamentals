namespace NetFundamentals.DesignPatterns.Interpreter
{
    // The AbstractExpression class defines the interface for interpreting expressions.
    public abstract class AbstractExpression
    {
        public abstract int Interpret(Context context);
    }
}

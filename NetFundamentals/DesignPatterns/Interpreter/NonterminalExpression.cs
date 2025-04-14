namespace NetFundamentals.DesignPatterns.Interpreter
{
    // The NonterminalExpression class implements the AbstractExpression interface and represents a non-terminal expression.
    public class NonterminalExpression : AbstractExpression
    {
        private AbstractExpression leftExpression;
        private AbstractExpression rightExpression;

        public NonterminalExpression(AbstractExpression leftExpression, AbstractExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }

        public override int Interpret(Context context)
        {
            int leftValue = leftExpression.Interpret(context);
            int rightValue = rightExpression.Interpret(context);
            return leftValue + rightValue;
        }
    }
}

namespace NetFundamentals.DesignPatterns.Interpreter
{
    // The TerminalExpression class implements the AbstractExpression interface and represents a terminal expression.
    public class TerminalExpression : AbstractExpression
    {
        private string variableName;

        public TerminalExpression(string variableName)
        {
            this.variableName = variableName;
        }

        public override int Interpret(Context context)
        {
            return context.GetVariable(variableName);
        }
    }
}

using System;

namespace NetFundamentals.DesignPatterns.Interpreter
{
    /// <summary>
    /// In this example, the Context class contains information that the interpreter uses to interpret expressions.
    /// The AbstractExpression class defines the interface for interpreting expressions.
    /// The TerminalExpression class implements the AbstractExpression interface and represents a terminal expression.
    /// The NonterminalExpression class implements the AbstractExpression interface and represents a non-terminal expression.
    ///
    /// The Client code creates a Context object and sets values for its variables.
    /// It then creates an AbstractExpression tree representing the expression to be interpreted.
    /// Finally, it calls the Interpret() method on the root node of the AbstractExpression tree.
    /// When the Interpret() method is called, the interpreter traverses the AbstractExpression tree and
    /// evaluates the expression using the values in the Context object.
    ///
    /// Using the Interpreter design pattern, the Client code can interpret expressions in a flexible and extensible way by defining
    /// new classes that implement the AbstractExpression interface.
    /// </summary>
    public class ExampleUsage
    {
        // The Client code creates a Context object and sets values for its variables.
        // It then creates an AbstractExpression tree representing the expression to be interpreted.
        // Finally, it calls the Interpret() method on the root node of the AbstractExpression tree.
        public void Execute()
        {
            Console.WriteLine("--==== Interpreter ====--");
            Context context = new Context();
            context.SetVariable("x", 10);
            context.SetVariable("y", 20);

            AbstractExpression expression = new NonterminalExpression(
                new TerminalExpression("x"),
                new TerminalExpression("y")
            );

            int result = expression.Interpret(context);
            Console.WriteLine(result);
        }
    }
}

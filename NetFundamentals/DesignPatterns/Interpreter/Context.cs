using System.Collections.Generic;

namespace NetFundamentals.DesignPatterns.Interpreter
{
    // The Context class contains information that the interpreter uses to interpret expressions.
    public class Context
    {
        private Dictionary<string, int> variables = new Dictionary<string, int>();

        public int GetVariable(string variableName)
        {
            if (variables.ContainsKey(variableName))
            {
                return variables[variableName];
            }
            return 0;
        }

        public void SetVariable(string variableName, int value)
        {
            variables[variableName] = value;
        }
    }
}

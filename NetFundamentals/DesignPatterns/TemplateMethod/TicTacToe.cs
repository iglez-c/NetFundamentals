using System;

namespace NetFundamentals.DesignPatterns.TemplateMethod
{
    public class TicTacToe : Game
    {
        protected override void Initialize()
        {
            Console.WriteLine("Initializing Tic Tac Toe...");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Starting Tic Tac Toe...");
        }

        protected override void EndPlay()
        {
            Console.WriteLine("Ending Tic Tac Toe...");
        }
    }
}

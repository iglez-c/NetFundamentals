using System;

namespace NetFundamentals.DesignPatterns.TemplateMethod
{
    /// <summary>
    /// In this example, we have a Game abstract class that defines the skeleton for a game.
    /// The Play method is the template method that calls the abstract Initialize, StartPlay, and EndPlay methods in the correct order.
    ///
    /// The Chess and TicTacToe classes are concrete implementations of the Game abstract class.
    /// They implement the Initialize, StartPlay, and EndPlay methods according to the rules of the respective games.
    ///
    /// In the Main method, we create instances of Chess and TicTacToe, and call their Play methods.
    /// The output shows the sequence of events that occur during the games.
    /// </summary>
    public class ExampleUsage
    {
        public void Execute()
        {
            Console.WriteLine("--==== TemplateMethod ====--");

            Game chess = new Chess();
            chess.Play();

            Game ticTacToe = new TicTacToe();
            ticTacToe.Play();
        }
    }
}

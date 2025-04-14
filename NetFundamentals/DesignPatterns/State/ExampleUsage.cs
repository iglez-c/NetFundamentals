using System;

namespace NetFundamentals.DesignPatterns.State
{
    /// <summary>
    /// In this example, we have a Player class which has different states (playing, paused, stopped).
    /// The Player class delegates its behavior to the current state object, which implements the State interface.
    /// Each concrete state class (PlayingState, PausedState, StoppedState) implements the behavior for its corresponding state.
    /// When the Player changes state, it passes itself as an argument to the new state object, so the state object can interact with
    /// the Player and change its state if necessary.
    /// Finally, the client code creates a Player object and performs different actions on it, which triggers the state transitions and
    /// outputs the corresponding messages.
    /// </summary>
    public class ExampleUsage
    {
        // Client code
        public void Execute()
        {
            Console.WriteLine("--==== State ====--");
            Player player = new Player();

            // Start playing
            player.ChangeState(new PlayingState());
            player.Play();

            // Pause playing
            player.Pause();

            // Resume playing
            player.Play();

            // Stop playing
            player.Stop();
        }
    }
}

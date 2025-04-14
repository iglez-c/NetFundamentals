using System;

namespace NetFundamentals.DesignPatterns.State
{
    // Concrete state classes
    public class PlayingState : IState
    {
        private Player player;

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void Play()
        {
            Console.WriteLine("Already playing");
        }

        public void Pause()
        {
            Console.WriteLine("Paused");
            this.player.ChangeState(new PausedState());
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            this.player.ChangeState(new StoppedState());
        }
    }
}

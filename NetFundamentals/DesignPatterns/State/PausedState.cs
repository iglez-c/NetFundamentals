using System;

namespace NetFundamentals.DesignPatterns.State
{
    public class PausedState : IState
    {
        private Player player;

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void Play()
        {
            Console.WriteLine("Resuming play");
            this.player.ChangeState(new PlayingState());
        }

        public void Pause()
        {
            Console.WriteLine("Already paused");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
            this.player.ChangeState(new StoppedState());
        }
    }
}

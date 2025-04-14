using System;

namespace NetFundamentals.DesignPatterns.State
{
    public class StoppedState : IState
    {
        private Player player;

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void Play()
        {
            Console.WriteLine("Starting to play");
            this.player.ChangeState(new PlayingState());
        }

        public void Pause()
        {
            Console.WriteLine("Cannot pause, not playing");
        }

        public void Stop()
        {
            Console.WriteLine("Already stopped");
        }
    }
}

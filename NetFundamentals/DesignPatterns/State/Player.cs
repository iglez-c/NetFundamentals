using System;

namespace NetFundamentals.DesignPatterns.State
{
    // Context class
    public class Player
    {
        private IState state;

        public void ChangeState(IState state)
        {
            Console.WriteLine($"Changing state to {state.GetType().Name}");
            this.state = state;
            this.state.SetPlayer(this);
        }

        public void Play()
        {
            this.state.Play();
        }

        public void Pause()
        {
            this.state.Pause();
        }

        public void Stop()
        {
            this.state.Stop();
        }
    }
}

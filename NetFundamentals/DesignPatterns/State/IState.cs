namespace NetFundamentals.DesignPatterns.State
{
    // State interface
    public interface IState
    {
        void SetPlayer(Player player);
        void Play();
        void Pause();
        void Stop();
    }
}

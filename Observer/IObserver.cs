namespace Observer
{
    /// <summary>
    /// The Observer interface.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Notification method.
        /// </summary>
        /// <param name="veggies"> Concrete subject. </param>
        void Update(Veggies veggies);
    }
}
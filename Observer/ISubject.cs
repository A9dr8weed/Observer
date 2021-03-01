namespace Observer
{
    /// <summary>
    /// Contains the code to manage subscribers and send them notifications.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attach an observer to the subject.
        /// </summary>
        /// <param name="observer"> Observer. </param>
        void Attach(IObserver observer);

        /// <summary>
        /// Detach an observer from the subject.
        /// </summary>
        /// <param name="observer"> Observer. </param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notify all observers about an event.
        /// </summary>
        void Notify();
    }
}
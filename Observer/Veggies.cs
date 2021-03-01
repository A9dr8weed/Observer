using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    /// ConcreteSubject: A concrete implementation of the ISubject interface. Defines a collection of observer objects.
    /// </summary>
    public class Veggies : ISubject
    {
        /// <summary>
        /// Price per pound.
        /// </summary>
        private double _pricePerPound;

        /// <summary>
        /// Collection of observers.
        /// </summary>
        private readonly List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Get price per pound.
        /// </summary>
        public double GetPricePerPound()
        {
            return _pricePerPound;
        }

        /// <summary>
        /// Automatically notify our observers of price changes.
        /// </summary>
        public void SetPricePerPound(double value)
        {
            if (_pricePerPound != value)
            {
                _pricePerPound = value;
                Notify();
            }
        }

        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        /// <summary>
        /// Attach an observer to the subject.
        /// </summary>
        /// <param name="observer"> Observer. </param>
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Detach an observer from the subject.
        /// </summary>
        /// <param name="observer"> Observer. </param>
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Notify all observers about an event.
        /// </summary>
        public void Notify()
        {
            foreach (IObserver item in _observers)
            {
                item.Update(this);
            }
        }
    }
}
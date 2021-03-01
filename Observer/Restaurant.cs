using System;

namespace Observer
{
    /// <summary>
    /// ConcreteObserver class, which represent specific restaurants.
    /// </summary>
    public class Restaurant : IObserver
    {
        /// <summary>
        /// Restourant name.
        /// </summary>
        private readonly string _name;

        /// <summary>
        /// Purchase treshold.
        /// </summary>
        private readonly double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        /// <summary>
        /// Implement feom IObserver.
        /// </summary>
        /// <param name="veggies"> Concrete subject. </param>
        public void Update(Veggies veggies)
        {
            Console.WriteLine($"Notified {_name} of {veggies.GetType().Name}'s  price change to {veggies.GetPricePerPound()} per pound.");

            if (veggies.GetPricePerPound() < _purchaseThreshold)
            {
                Console.WriteLine($"{_name} wants to buy some {veggies.GetType().Name}!");
            }
        }
    }
}
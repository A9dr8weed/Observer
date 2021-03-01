using System;

namespace Observer
{
    public static class Program
    {
        private static void Main()
        {
            // Create price watch for Carrots 
            // and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.SetPricePerPound(0.79);
            Console.WriteLine();

            carrots.SetPricePerPound(0.76);
            Console.WriteLine();

            carrots.SetPricePerPound(0.74);
            Console.WriteLine();

            carrots.SetPricePerPound(0.81);
            Console.WriteLine();
        }
    }
}
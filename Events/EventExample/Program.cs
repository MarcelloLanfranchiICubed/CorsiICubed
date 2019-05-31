using System;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of an instance of the publisher
            var counter = new Counter();

            // Subscription of the methods LightOn and SayHello to the event ThresholdReached.
            // When the event will be activated, this methods will be called.
            counter.ThresholdReached += LightBulb.LightOn;
            counter.ThresholdReached += LightBulb.SayHello;

            Console.WriteLine("press '+' key to increase total");
            while (Console.ReadKey(true).KeyChar == '+')
            {
                Console.WriteLine("adding one");
                counter.Add(1);
            }
        }
    }
}

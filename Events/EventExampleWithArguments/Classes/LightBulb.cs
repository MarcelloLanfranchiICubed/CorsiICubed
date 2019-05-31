using System;

namespace EventExampleWithArguments.Classes
{
    /// <summary>
    /// This class plays the role of a subscriber for the event ThresholdReached, declared in Counter
    /// </summary>
    public static class LightBulb
    {
        public static void LightOn(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"The light is on: the threshold {e.Threshold} is reached at {e.TimeReached}");
        }

        public static void SayHello(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("Hello: the threshold is reached");
        }
    }
}

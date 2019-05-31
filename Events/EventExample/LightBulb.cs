using System;

namespace EventExample
{
    /// <summary>
    /// This class plays the role of a subscriber for the event ThresholdReached, declared in Counter
    /// </summary>
    public static class LightBulb
    {
        public static void LightOn(object sender, EventArgs e)
        {
            Console.WriteLine("The light is on: the threshold is reached");
        }

        public static void SayHello(object sender, EventArgs e)
        {
            Console.WriteLine("Hello: the threshold is reached");
        }
    }
}

using System;

namespace EventExample
{
    /// <summary>
    /// This class is the publisher of the event ThresholdReached: when the threshold is reached, then the event is activated
    /// </summary>
    public class Counter
    {
        /// <summary>
        /// Declaration of the event. EventHandler is the delegate on which the event is build on
        /// </summary>
        public event EventHandler ThresholdReached;

        private int threshold = 7;
        private int total;
        
        /// <summary>
        /// Thanks to this method, the delegate points on the event when it happens
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnThresholdReached(EventArgs e)
        {
            // Here, we are declaring that the delegate must point on the event
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                // Here, the delegate carrying the event is invoked
                handler(sender: this, e);
            }
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
            }
        }
    }
}

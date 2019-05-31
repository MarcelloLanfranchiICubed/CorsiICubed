using System;

namespace EventExampleWithArguments.Classes
{
    /// <summary>
    /// This class contains all the arguments a want to pass to the functions related to the delegate
    /// </summary>
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}

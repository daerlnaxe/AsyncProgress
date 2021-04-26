
using AsyncProgress.Cont;

namespace AsyncProgress
{
    /// <summary>
    /// Interface with basis to signal progression
    /// </summary>
    public interface I_SigProgress
    {



        /// <summary>
        /// Current progress value
        /// </summary>
        public event ProgressHandler UpdateProgress;

        /// <summary>
        /// Maximum reachable
        /// </summary>
        //public event DoubleHandler MaximumProgress;


        /// <summary>
        /// Message for current status
        /// </summary>
        public event StateHandler UpdateStatus;

        /// <summary>
        /// Message for current status with new line
        /// </summary>
        //public event MessageHandler UpdateStatusNL;


    }
}

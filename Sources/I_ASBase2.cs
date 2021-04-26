using DxLocalTransf.Progress;
using System.Threading;

namespace AsyncProgress
{
    // public delegate void DoubleDel(Double value);
    // public delegate void StringDel(string value);

    /// <summary>
    /// Base class to implement in object that will be used for Tasks to make compatible with progression windows
    /// </summary>
    public interface I_ASBase2:I_ASBase
    {
       /* /// <summary>
        /// Say progress
        /// </summary>
        public event DoubleDel UpdateProgress;

        /// <summary>
        /// Says current part of Task
        /// </summary>
        public event StringDel UpdateStatus;

        /// <summary>
        /// Maximum of the Task
        /// </summary>
        public event DoubleDel MaximumProgress;*/

        CancellationTokenSource TokenSource { get; }

        /// <summary>
        /// Token to cancel Task
        /// </summary>
        CancellationToken CancelToken { get; }

        /// <summary>
        /// Used to pause Task
        /// </summary>
        bool IsPaused { get; set; }


        void StopTask();

        
        public void Pause(int timeSleep = 100)
        {
            while (IsPaused)
                Thread.Sleep(100);
        }

    }
}

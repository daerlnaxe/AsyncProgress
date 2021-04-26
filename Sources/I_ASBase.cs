using System.Threading;

namespace AsyncProgress
{
    // public delegate void DoubleDel(Double value);
    // public delegate void StringDel(string value);

    /// <summary>
    /// Base class to implement in object that will be used for Tasks to make compatible with progression windows
    /// </summary>
    public interface I_ASBase
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

        //
        bool IsInterrupted { get; }


        bool CancelFlag { get; }

        /// <summary>
        /// 
        /// </summary>
        void StopTask();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeSleep"></param>
        public void Pause(int timeSleep);

    }
}

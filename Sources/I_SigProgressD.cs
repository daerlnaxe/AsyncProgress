using AsyncProgress.Cont;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncProgress
{
    /// <summary>
    /// Interface with more to signal progression
    /// </summary>
    public interface I_SigProgressD: I_SigProgress
    {
        /// <summary>
        /// Current value for the Total state of the task
        /// </summary>
        public event ProgressHandler UpdateProgressT;

        /// <summary>
        /// Current state for the Total status of the task
        /// </summary>
        public event StateHandler UpdateStatusT;

        /// <summary>
        /// Current state for the Total status of the task with New Line
        /// </summary>
        //public event MessageHandler UpdateStatusTNL;

        /// <summary>
        /// Maximum for the Total of the task
        /// </summary>
        //public event DoubleHandler MaximumProgressT;
    }
}

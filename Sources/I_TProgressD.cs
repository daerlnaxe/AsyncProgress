using AsyncProgress.Cont;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncProgress
{
    public interface I_TProgressD: I_TProgress
    {
        
        /// Set Current Total Progress
        /// </summary>
        /// <param name="value"></param>
        public void SetTotalProgress(object sender, ProgressArg arg);

        /// <summary>
        /// Set Current Total Operation 
        /// (like when you have finished and the waiter ask to you if you finished, and you say "no i will eat the plate".
        /// I mean, you know... Ok i'm tired
        /// </summary>
        /// <param name="value"></param>
        public void SetTotalStatus(object sender, StateArg arg);

    }
}


namespace AsyncProgress
{        

    /// <summary>
    /// I_AsBase + I_EProgressC: Basic elements for asynchrone + events C
    /// </summary>
    public interface I_AsyncSigD: I_ASBase, I_SigProgressD
    {
        /*
        /// <summary>
        /// Function to launch in background
        /// </summary>
        /// <remarks>
        /// Need a Cancellation token and a boolean to pause function
        /// </remarks>
        Func<CancellationToken, bool, object> TaskToRun { get; }
        */

        /// <summary>
        /// Objet contenant la méthode
        /// </summary>
     //   IASBaseC Objet { get; }

        /// <summary>
        /// Tâche à lancer
        /// </summary>
     //   Func<object> TaskToRun { get; }

        /// <summary>
        /// Delay before to launch
        /// </summary>
       /// public int Delay { get; set; }

        /// <summary>
        /// Task runnig in background
        /// </summary>
        //public Task TaskRunning { get; }

        //public void Initialize<T>(T objet, Func<Object> taskToRun) where T : IASBaseC;

        //public void Launch_Task(Func<object> Ending, int delay = 50);


        /// <summary>
        /// Call Token to stop task
        /// </summary>
            // void StopTask();

            /// <summary>
            /// Launch task
            /// </summary>
            // void Launch_Task();


    }
}

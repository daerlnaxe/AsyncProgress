using AsyncProgress.Cont;

namespace AsyncProgress
{
    public interface I_TProgress
    {
        /// <summary>
        /// Set Current Progress
        /// </summary>
        /// <param name="value"></param>
        void SetProgress(object sender, ProgressArg arg);

        /// <summary>
        /// Set Current operation
        /// </summary>
        /// <param name="value"></param>
        void SetStatus(object sender, StateArg arg);
        



     
    }
}

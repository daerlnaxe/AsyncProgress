using System.ComponentModel;

namespace AsyncProgress
{
    public interface I_RProgress: INotifyPropertyChanged
    {

        /// <summary>
        /// Describe type of operation
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// Current position
        /// </summary>
        double Progress { get; set; }


        /// <summary>
        /// Current operation
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Maximum progression possible
        /// </summary>
        double MaxValue { get; set; }



    }
}

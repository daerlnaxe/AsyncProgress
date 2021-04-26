
namespace AsyncProgress
{
    /// <summary>
    /// Properties interface for the datacontext of a collection progression
    /// </summary>
    /// 
    public interface I_RProgressD: I_RProgress
    {
        /// <summary>
        /// Position of total progression
        /// </summary>
        double ProgressTotal { get; set; }

        /// <summary>
        /// Total status
        /// </summary>
        public string TotalStatus { get; set; }

        /// <summary>
        /// Maximum progress for total
        /// </summary>
        public double MaximumTotal { get; set; }


    }
}

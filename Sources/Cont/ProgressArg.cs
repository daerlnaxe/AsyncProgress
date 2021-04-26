
namespace AsyncProgress.Cont
{
    public delegate void ProgressHandler(object sender, ProgressArg m);
    public struct ProgressArg
    {
        public double Progress {get;}
        public double Total {get;}

        public bool Cancel { get; set; }

        public ProgressArg(double progress, double total ,bool cancel)
        {
            Progress = progress;
            Total = total;
            Cancel= cancel;
        }
    }
}

using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgress.ToImp
{
    public abstract class A_ASBase : I_ASBase
    {
        /*public abstract event DoubleHandler UpdateProgress;
        public abstract event DoubleHandler MaximumProgress;
        public abstract event MessageHandler UpdateStatus;*/

        public virtual CancellationTokenSource TokenSource { get; set; }= new CancellationTokenSource();

        public virtual CancellationToken CancelToken { get; }

        public virtual bool IsPaused { get; set; }
        public virtual bool IsInterrupted { get; set; }
        public virtual bool CancelFlag { get; protected set; }

        public A_ASBase()
        {            
            CancelToken = TokenSource.Token;
        }



        public abstract void StopTask();

        public virtual async void Pause(int timeSleep = 100)
        {
            while (IsPaused)
            {
                await Task.Delay(100);
            }
        }
    }
}

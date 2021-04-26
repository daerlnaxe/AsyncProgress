using AsyncProgress.Cont;
using System.Threading;

namespace AsyncProgress.ToImp
{
    public abstract class A_AsyncSig : I_AsyncSig
    {
        public virtual CancellationTokenSource TokenSource { get; } = new CancellationTokenSource();

        public virtual CancellationToken CancelToken => TokenSource.Token;

        public virtual bool IsPaused { get; set; }
        public virtual bool IsInterrupted { get; set; }
        public virtual bool CancelFlag { get; protected set; }

        public virtual int InternalTimer { get; set; } = 100;

        public abstract event ProgressHandler UpdateProgress;
        public abstract event StateHandler UpdateStatus;

        public abstract void Pause(int timeSleep);

        public abstract void StopTask();
    }
}

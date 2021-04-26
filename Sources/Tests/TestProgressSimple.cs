using AsyncProgress.Cont;
using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncProgress.Tests
{
    public class TestProgressSimple : I_AsyncSig
    {
        public event ProgressHandler UpdateProgress;
        public event StateHandler UpdateStatus;

        public CancellationTokenSource TokenSource { get; } = new CancellationTokenSource();
        public CancellationToken CancelToken { get; }

        public bool IsPaused { get; set; }

        public bool IsInterrupted { get; private set; }

        public bool CancelFlag { get; private set; }
        public int InternalTimer { get; set; }

        public TestProgressSimple()
        {
            CancelToken = TokenSource.Token;
        }



        public object Run(int timeSleep = 100)
        {

            for (int i = 0; i < 100; i++)
            {
                while (IsPaused)
                    Thread.Sleep(100);

                if (CancelToken.IsCancellationRequested)
                    return null;

                UpdateProgress?.Invoke(this, new ProgressArg( i, 100, CancelFlag));
                Debug.WriteLine(i);
                UpdateStatus?.Invoke(this, new StateArg( $"File {i}", CancelFlag));
                // db2.CurrentOP = $"{DxTBLang.File} {i}";


                Thread.Sleep(timeSleep);

            }
            UpdateProgress?.Invoke(this, new ProgressArg(100, 100, CancelFlag));
            //db2.AsyncClose();

            
            return null;
        }

        public void StopTask()
        {
            TokenSource.Cancel();

#if DEBUG
            Debug.WriteLine($"[AM_ProgressC] Cancel token requested");
#endif
        }

        public void Pause(int timeSleep)
        {
            throw new NotImplementedException();
        }
    }
}

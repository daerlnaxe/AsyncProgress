using AsyncProgress.Cont;
using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncProgress.Tests
{
    public class TestProgressCollec : I_AsyncSigD
    {

        public event ProgressHandler UpdateProgress;
        public event StateHandler UpdateStatus;

        public event ProgressHandler UpdateProgressT;
        public event StateHandler UpdateStatusT;

        public CancellationTokenSource TokenSource { get; } = new CancellationTokenSource();

        public CancellationToken CancelToken { get; }

        public bool IsPaused { get; set; }

        public bool IsInterrupted { get; private set; }
        public bool CancelFlag { get; private set; }
        
        public int InternalTimer { get; set; }

        public TestProgressCollec()
        {
            CancelToken = TokenSource.Token;
        }


        public object Run(int timeSleep)
        {
            if (timeSleep < 10)
                throw new Exception($"Timesleep trop bas: {timeSleep}");

            try
            {
                // Thread.Sleep(500);
                // Boucle Totale
                for (int i = 0; i < 10; i++)
                {
                    UpdateStatusT?.Invoke(this, new StateArg( "New Task", CancelFlag));
                    UpdateProgressT?.Invoke(this, new ProgressArg(0, 100, CancelFlag));

                    for (int j = 0; j < 50; j++)
                    {
                        if (CancelFlag)
                            return false;

                        UpdateProgress?.Invoke(this, new ProgressArg(j * 2, 100, CancelFlag));

                        while (IsPaused)
                            Thread.Sleep(100);

                        if (CancelToken.IsCancellationRequested)
                            return null;

                        UpdateStatus?.Invoke(this, new StateArg( $"File {i}.{j}", CancelFlag));
                        // db2.CurrentOP = $"{DxTBLang.File} {i}";


                        Thread.Sleep(timeSleep);
                    }

                    UpdateProgress?.Invoke(this, new ProgressArg(100, 100, false));
                }

                UpdateProgressT?.Invoke(this, new ProgressArg(0, 100, false));
                Thread.Sleep(100);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc);
            }
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

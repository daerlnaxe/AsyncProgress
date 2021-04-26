using AsyncProgress;
using AsyncProgress.Basix;
using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncProgress.Tools
{
    public class MawEvo<T> :I_ASBase where T: I_RProgressD, I_TProgressD,new()
    {
        public T Parler { get; set; } = new T();

        public CancellationTokenSource TokenSource { get; } = new CancellationTokenSource();

        public CancellationToken CancelToken => TokenSource.Token;

        public bool IsPaused { get; set; }

        public bool IsInterrupted { get; set; }

        public bool CancelFlag => throw new NotImplementedException();

        public MawEvo()
        {
            Debug.WriteLine("Using Maw without retouting");
        }

        public MawEvo(I_AsyncSigD objet)
        {
            RerouteSignal(objet);

        }

        public void RerouteSignal<U>(U objet) where U : I_AsyncSigD
        {
            objet.UpdateProgress += Parler.SetProgress;
            objet.UpdateStatus += Parler.SetStatus;

            objet.UpdateProgressT += Parler.SetTotalProgress;
            objet.UpdateStatusT += Parler.SetTotalStatus;
        }


        public void StopTask()
        {
            TokenSource.Cancel();
            Debug.WriteLine("Maw, stop task asked");

            // throw new System.NotImplementedException();
        }

        public void Pause(int timeSleep)
        {
            throw new NotImplementedException();
        }
    }
}

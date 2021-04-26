using AsyncProgress;
using AsyncProgress.Basix;
using System.Diagnostics;
using System.Threading;

namespace AsyncProgress.Tools
{
    /*
     * Maw is the answer because Maw is Maw, get a Maw or become a Maw.
     * All-in-One to use method and send progress
    */
    public class Maw<T> : I_ASBase where T : I_RProgressD, I_TProgressD, new()
    {
        public T Parler { get; set; } = new T();


        public CancellationTokenSource TokenSource { get; } = new CancellationTokenSource();

        public CancellationToken CancelToken => TokenSource.Token;

        public bool IsPaused { get; set; }

        public bool IsInterrupted { get; set; }

        public bool CancelFlag { get; protected set; }

        public Maw()

        {
            Debug.WriteLine("Using Maw without retouting");

        }

        public Maw(I_AsyncSig objet)
        {
            RerouteSignal(objet);
        }



        public virtual void RerouteSignal<T>(T objet)where T: I_AsyncSig
        {
            objet.UpdateProgress += Parler.SetProgress;
            objet.UpdateStatus += Parler.SetStatus;
        }

        public void StopTask()
        {
            TokenSource.Cancel();
            Debug.WriteLine("Maw, stop task asked");

            // throw new System.NotImplementedException();
        }

        public void Pause(int timeSleep)
        {
            throw new System.NotImplementedException();
        }

        /*
        public void SetProgress(object sender, double value)
        {
            UpdateProgress?.Invoke(sender, value);
        }

        public void SetStatus(object sender, string value)
        {
            UpdateStatus?.Invoke(sender, value);
        }

        public void SetMaximum(object sender, double value)
        {
            MaximumProgress?.Invoke(sender, value);
        }


        public void SetTotalProgress(object sender, double value)
        {
            UpdateProgressT?.Invoke(sender, value);
        }

        public void SetTotalStatus(object sender, string value)
        {
            UpdateStatusT?.Invoke(sender, value);
        }

        public void SetTotalMaximum(object sender, double value)
        {
            MaximumProgressT?.Invoke(sender, value);
        }


        */



    }
}

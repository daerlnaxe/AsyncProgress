using AsyncProgress.Basix;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncProgress.Tools
{
    public class PersistProgressD: A_ProgressPersistD
    {
        public PersistProgressD(I_SigProgressD objet)
        {
            objet.UpdateProgress += this.SetProgress;
            objet.UpdateStatus += this.SetStatus;

            objet.UpdateProgressT += this.SetTotalProgress;
            objet.UpdateStatusT += this.SetTotalStatus;
        }
    }
}

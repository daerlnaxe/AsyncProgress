﻿using AsyncProgress;
using AsyncProgress.Basix;

namespace AsyncProgress.Tools
{
    /// <summary>
    /// Permet d'utiliser un objet qui sert de passerelle entre des signaux et la progression
    /// </summary>
    public class EphemProgress : A_ProgressEph
    {
        public EphemProgress()
        {
        }

        public EphemProgress(I_SigProgress objet)
        {
            objet.UpdateProgress += this.SetProgress;
            objet.UpdateStatus += this.SetStatus;
        }


    }
}

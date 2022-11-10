using AsyncProgress;
using AsyncProgress.Cont;
using System.Diagnostics;
#if DEBUG
using System.Diagnostics;
#endif

namespace AsyncProgress.Basix
{
    /// <summary>
    /// Modele utilisé pour les box progress simple, ça permet de passer un objet qui n'a que des events
    /// </summary>
    /// <remarks>
    /// Emploi d'un booléen pour savoir si on doit écrire à la suite ou non
    /// </remarks>
    public abstract class A_ProgressEph : A_Progress, I_RProgress, I_TProgress
    {
        private bool _WriteToEnd = false;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Ne linker directement que si on veut ignorer le mode sans ligne de retour
        /// </remarks>
        public override string Status
        {
            get => _Status;
            set
            {
                if (_WriteToEnd)
                {
                    _Status = value;
                    Debug.WriteLine($"[{nameof(_Status)}] : {_Status}");

                }
                else
                {
                    _Status += value;
                    Debug.Write(_Status);
                }

                OnPropertyChanged();
            }
        }



        /*
        public void StopTask()
        {

        }*/

        #region Virtual

        public override void SetStatus(object sender, StateArg arg)
        {
            Status = arg.Message;
            _WriteToEnd = arg.EndOfLine;
        }

        #endregion
    }
}

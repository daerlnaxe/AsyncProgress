﻿using AsyncProgress.Cont;
using System.Diagnostics;

namespace AsyncProgress.Basix
{
    public class A_ProgressPersistD: A_ProgressPersist, I_RProgressD, I_TProgressD
    {
        private double _ProgressTotal;
        public virtual double ProgressTotal
        {
            get => _ProgressTotal;
            set
            {
#if DEBUG
                Debug.WriteLine($"[M_ProgressC] {nameof(ProgressTotal)}: {value}");
#endif
                _ProgressTotal = value;
                OnPropertyChanged();
            }
        }


        private string _TotalStatus;
        private bool _WriteToEndT;
        public virtual string TotalStatus
        {
            get => _TotalStatus;
            set
            {
                if (_WriteToEndT)
                {
                    Debug.WriteLine($"[{nameof(TotalStatus)}] CurrentProgress: {value}");
                    _TotalStatus = value;

                }
                else
                {
                    _TotalStatus += value;
                    Debug.Write(value);
                }
                _TotalStatus = value;
                OnPropertyChanged();
            }
        }


        private double _maxProgressT;
        /// <summary>
        /// </summary>
        /// <remarks>
        /// Normalement inutile de mettre à jour en temps réel
        /// </remarks>
        public virtual double MaximumTotal
        {
            get => _maxProgressT;
            set
            {
                _maxProgressT = value;
#if DEBUG
                Debug.WriteLine($"[M_ProgressC] {nameof(MaximumTotal)}: {value}");
#endif
                OnPropertyChanged();
            }
        }



        public virtual void SetTotalProgress(object sender, ProgressArg arg)
        {
            MaximumTotal = arg.Total;
            ProgressTotal = arg.Progress;
        }

        public virtual void SetTotalStatus(object sender, StateArg arg)
        {
            TotalStatus = arg.Message;
            _WriteToEndT = arg.EndOfLine;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AsyncProgress
{
    public interface IEcoProgress
    {
        /// <summary>
        /// Permet de régler un timer pour le calcul des pourcentages des progressions et les émissions
        /// du signal
        /// </summary>
        /// <remarks>
        /// Milliseconds
        /// </remarks>
        public int TimeLimit { get; set; }

        public Stopwatch Timer { get; }
    }
}

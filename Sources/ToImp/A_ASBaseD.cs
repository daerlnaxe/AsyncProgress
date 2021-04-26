using System;
using System.Collections.Generic;
using System.Text;

namespace DxLocalTransf.Progress.ToImp
{
    public abstract class A_ASBaseD : A_ASBase, I_ASBase
    {
        public abstract event DoubleHandler UpdateProgressT;
        public abstract event MessageHandler UpdateStatusT;
        public abstract event DoubleHandler MaximumProgressT;
    }
}

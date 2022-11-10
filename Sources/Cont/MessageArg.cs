using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncProgress.Cont
{
    public delegate void MessageHandler(object sender, MessageArg arg);
    public class  MessageArg
    {
        public string Message { get; set; }
        public bool EndOfLine { get; set; } = true;
        public int Level { get; set; }

        public MessageArg(string m)
        {
            Message = m;
        }

        public MessageArg(string m, bool eol)
        {
            Message = m;
            EndOfLine = eol;
        }

        public MessageArg(string m, int lvl)
        {
            Message = m;
            Level = lvl;
        }

    }
}

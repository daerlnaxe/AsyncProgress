
namespace AsyncProgress.Cont
{
    public delegate void StateHandler(object sender, StateArg state);
    public class StateArg: MessageArg
    {

        //public string Message { get; }

        public bool CancelFlag { get; set; }




        public StateArg(string message) : base(message)
        {
            EndOfLine = true;
        }

        public StateArg(string message, bool cancel, bool endOfLine = true): base(message, endOfLine)
        {
            CancelFlag = cancel;
        }

        public StateArg(MessageArg y, bool cancelFlag):base(y.Message, y.EndOfLine)
        {
            CancelFlag = cancelFlag;
        }

        public StateArg(string message, int level, bool cancelFlag = false, bool eol = false):base(message, eol)
        {
            CancelFlag = cancelFlag;
            Level = level;
        }
    }
}

using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class TVOnCommand : ICommand
    {
        readonly TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
            _tv.SetInputChannel();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}

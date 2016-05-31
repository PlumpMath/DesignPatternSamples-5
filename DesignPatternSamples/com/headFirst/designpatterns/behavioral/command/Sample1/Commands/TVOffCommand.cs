using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class TVOffCommand : ICommand
    {
        readonly TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}

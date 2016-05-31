using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class StereoOnCommand : ICommand
    {
        readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}

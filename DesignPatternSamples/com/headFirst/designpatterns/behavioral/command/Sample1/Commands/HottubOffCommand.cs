using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class HottubOffCommand : ICommand
    {
        readonly Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.setTemperature(90);
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.On();
        }
    }
}

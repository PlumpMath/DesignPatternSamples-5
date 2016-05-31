using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class HottubOnCommand : ICommand
    {
        readonly Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.On();
            _hottub.setTemperature(104);
            _hottub.Circulate();
        }

        public void Undo()
        {
            _hottub.Off();
        }
    }
}

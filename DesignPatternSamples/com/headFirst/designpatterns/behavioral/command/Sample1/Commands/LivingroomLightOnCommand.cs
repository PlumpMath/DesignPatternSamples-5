using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class LivingroomLightOnCommand : ICommand
    {
        readonly Light _light;

        public LivingroomLightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}

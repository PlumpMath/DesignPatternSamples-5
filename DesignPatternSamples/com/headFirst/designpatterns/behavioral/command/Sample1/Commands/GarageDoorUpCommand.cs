using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class GarageDoorUpCommand : ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
            _garageDoor.LightOn();
        }

        public void Undo()
        {
            _garageDoor.LightOff();
            _garageDoor.Down();
        }
    }
}

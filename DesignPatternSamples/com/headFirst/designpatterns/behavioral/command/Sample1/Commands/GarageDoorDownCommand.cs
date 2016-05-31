using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class GarageDoorDownCommand : ICommand
    {
        readonly GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.LightOff();
            _garageDoor.Down();            
        }

        public void Undo()
        {
            _garageDoor.Up();
            _garageDoor.LightOn();
        }
    }
}

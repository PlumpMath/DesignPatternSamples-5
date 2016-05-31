using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands;
using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Invoker;
using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;
using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1
{
    class CommandSample1
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            var light = new Light("Living Roon");
            var tv = new TV("Living Room");
            var stereo = new Stereo("Living Room");
            var hottub = new Hottub();
            var garageDoor = new GarageDoor(string.Empty);

            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);
            var stereoOnCommand = new StereoOnCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);
            var tvOnCommand = new TVOnCommand(tv);
            var tvOffCommand = new TVOffCommand(tv);
            var hottubOnCommand = new HottubOnCommand(hottub);
            var hottubOffCommand = new HottubOffCommand(hottub);

            var partyOn = new ICommand[] { lightOnCommand, stereoOnCommand, tvOnCommand, hottubOnCommand };
            var partyOff = new ICommand[] { lightOffCommand, stereoOffCommand, tvOffCommand, hottubOffCommand };

            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            //remoteControl.SetCommand(0, lightOnCommand, lightOffCommand);
            //remoteControl.SetCommand(1, tvOnCommand, tvOffCommand);
            //remoteControl.SetCommand(2, stereoOnCommand, stereoOffCommand);
            //remoteControl.SetCommand(3, hottubOnCommand, hottubOffCommand);
            remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);
            remoteControl.SetCommand(6, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonPressed(2);
            remoteControl.OnButtonPressed(0);
            remoteControl.OnButtonPressed(3);
            remoteControl.OnButtonPressed(1);

            remoteControl.OffButtonPressed(2);
            remoteControl.OffButtonPressed(0);
            remoteControl.OffButtonPressed(3);
            remoteControl.OffButtonPressed(1);

            remoteControl.OnButtonPressed(6);
            remoteControl.UndoButtonPressed();

            Console.Read();
        }
    }
}

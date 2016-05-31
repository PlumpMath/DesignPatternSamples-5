using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class LightOffCommand : ICommand
    {
        readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}

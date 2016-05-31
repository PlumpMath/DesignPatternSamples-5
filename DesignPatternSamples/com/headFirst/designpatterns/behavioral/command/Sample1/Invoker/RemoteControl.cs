using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands;
using System.Text;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Invoker
{
    class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;
        ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for(int i = 0; i < _onCommands.Length; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonPressed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonPressed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine("------ Remote Control -------");

            for (int i = 0; i < _onCommands.Length; i++)
                builder.AppendFormat("[slot {0}] {1}\t{2}\r\n", i, _onCommands[i].GetType().Name, _offCommands[i].GetType().Name);
            builder.AppendFormat("[undo] {0}\r\n", _undoCommand.GetType().Name);
            return builder.ToString();
        }
    }
}

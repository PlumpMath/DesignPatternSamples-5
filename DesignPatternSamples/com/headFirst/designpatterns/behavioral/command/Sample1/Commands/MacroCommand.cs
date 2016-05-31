namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Commands
{
    class MacroCommand : ICommand
    {
        ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < _commands.Length; i++)
                _commands[i].Execute();
        }

        public void Undo()
        {
            for (int i = _commands.Length - 1; i >= 0; i--)
                _commands[i].Undo();
        }
    }
}

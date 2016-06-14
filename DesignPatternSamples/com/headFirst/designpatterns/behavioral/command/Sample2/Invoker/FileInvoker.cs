using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Invoker
{
    class FileInvoker
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }

        public void Execute(ICommand[] commands)
        {
            foreach (var command in commands)
                command.Execute();
        }
    }
}

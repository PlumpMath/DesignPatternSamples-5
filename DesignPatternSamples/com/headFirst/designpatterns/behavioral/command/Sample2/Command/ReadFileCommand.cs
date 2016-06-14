using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command
{
    class ReadFileCommand : ICommand
    {
        IFileSystemReceiver _receiver;

        public ReadFileCommand(IFileSystemReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ReadFile();
        }
    }
}

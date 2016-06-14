using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command
{
    class WriteFileCommand : ICommand
    {
        IFileSystemReceiver _receiver;

        public WriteFileCommand(IFileSystemReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.WriteFile();
        }
    }
}

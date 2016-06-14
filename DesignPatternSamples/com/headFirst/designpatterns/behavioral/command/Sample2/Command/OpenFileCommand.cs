using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command
{
    class OpenFileCommand : ICommand
    {
        IFileSystemReceiver _receiver;

        public OpenFileCommand(IFileSystemReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.OpenFile();
        }
    }
}

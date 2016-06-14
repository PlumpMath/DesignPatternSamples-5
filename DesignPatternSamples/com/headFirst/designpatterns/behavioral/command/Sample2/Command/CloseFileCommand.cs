using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command
{
    class CloseFileCommand : ICommand
    {
        IFileSystemReceiver _receiver;

        public CloseFileCommand(IFileSystemReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.CloseFile();
        }
    }
}

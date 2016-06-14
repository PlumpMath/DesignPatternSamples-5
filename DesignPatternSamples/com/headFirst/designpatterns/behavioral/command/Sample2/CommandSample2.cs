using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Command;
using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Invoker;
using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2
{
    class CommandSample2
    {
        static void Main(string[] args)
        {
            var fileSystemReceiver = FileSystemReceiverUtil.GetFileSystemReceiver();

            var openFileCommand = new OpenFileCommand(fileSystemReceiver);

            var closeFileCommand = new CloseFileCommand(fileSystemReceiver);

            var readFileCommand = new ReadFileCommand(fileSystemReceiver);

            var writeFileCommand = new WriteFileCommand(fileSystemReceiver);

            var invoker = new FileInvoker();

            invoker.Execute(openFileCommand);

            invoker.Execute(closeFileCommand);

            invoker.Execute(new ICommand[] { openFileCommand, readFileCommand, writeFileCommand, closeFileCommand });

            Console.Read();
        }
    }
}

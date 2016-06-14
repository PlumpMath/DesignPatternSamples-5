using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver
{
    class WindowsFileSystemReceiver : IFileSystemReceiver
    {
        public void CloseFile()
        {
            Console.WriteLine("Closing file in windows OS");
        }

        public void OpenFile()
        {
            Console.WriteLine("Opening file in windows OS");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading file in windows OS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing file in windows OS");
        }
    }
}

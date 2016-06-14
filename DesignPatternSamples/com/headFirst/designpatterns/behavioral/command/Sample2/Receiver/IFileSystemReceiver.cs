namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver
{
    interface IFileSystemReceiver
    {
        void OpenFile();

        void CloseFile();

        void ReadFile();

        void WriteFile();
    }
}

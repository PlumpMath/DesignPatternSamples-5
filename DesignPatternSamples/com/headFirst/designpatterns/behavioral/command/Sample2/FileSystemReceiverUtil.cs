using Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2.Receiver;
using System.Management;
using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample2
{
    class FileSystemReceiverUtil
    {
        public static IFileSystemReceiver GetFileSystemReceiver()
        {
            var osName = getOSFriendlyName();
            Console.WriteLine(string.Concat("Underlaying OS is: ", osName));

            if (osName.Contains("Windows"))
                return new WindowsFileSystemReceiver();
            else
                return new UnixFileSystemReceiver();
        }

        static string getOSFriendlyName()
        {
            string result = string.Empty;
            var searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (var os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }
    }
}

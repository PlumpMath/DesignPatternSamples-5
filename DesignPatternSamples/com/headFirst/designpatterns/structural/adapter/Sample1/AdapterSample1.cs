using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class AdapterSample1
    {
        static void Main(string[] args)
        {
            IAccount account = null;

            account = new StandardAccount(2000);
            Console.WriteLine("Account balance = {0}", account.GetBalance());

            account = new ObjecrTypeAccountAdapter(new OffshoreAccount(4000));
            Console.WriteLine("Account balance = {0}", account.GetBalance());

            account = new ClassTypeAccountAdapter(4000);
            Console.WriteLine("Account balance = {0}", account.GetBalance());

            Console.Read();
        }
    }
}

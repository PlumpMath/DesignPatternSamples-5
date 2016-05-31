using System;
using System.Threading;

namespace Com.HeadFirst.DesignPatterns.Creational.Singleton.Sample1
{
    class SingletonSample1
    {
        static void Main(string[] args)
        {
            //var classicSingleton = Classic.Singleton.CreateInstance(65);

            //Console.WriteLine("Classic Singleton.InstanceValue = {0}", classicSingleton.InstanceValue);

            //var classicSingleton1 = Classic.Singleton.CreateInstance(32);

            //Console.WriteLine("Classic Singleton.InstanceValue = {0}", classicSingleton1.InstanceValue);

            var sample = new SingletonSample1();

            var thread1 = new Thread(() => sample.createSingletonInstanceInThread(95));

            var thread2 = new Thread(() => sample.createSingletonInstanceInThread(22));

            thread1.Start();

            thread2.Start();

            Console.Read();
        }

        void createSingletonInstanceInThread(int instanceValue)
        {
            var classicSingleton = Classic.Singleton.CreateInstance(instanceValue);

            Console.WriteLine("From Thread {1} Classic Singleton.InstanceValue = {0}", classicSingleton.InstanceValue, Thread.CurrentThread.ManagedThreadId);
        }
    }
}

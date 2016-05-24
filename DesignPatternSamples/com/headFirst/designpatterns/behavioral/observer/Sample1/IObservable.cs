namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample1
{
    interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyAll();
    }
}

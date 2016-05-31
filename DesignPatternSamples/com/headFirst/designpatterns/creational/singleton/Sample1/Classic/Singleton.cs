namespace Com.HeadFirst.DesignPatterns.Creational.Singleton.Sample1.Classic
{
    sealed class Singleton
    {
        private static Singleton _uniqueInstance;

        private readonly int _instanceValue;

        private Singleton(int instanceValue)
        {
            _instanceValue = instanceValue;
        }

        public int InstanceValue { get { return _instanceValue; } }

        public static Singleton CreateInstance(int instanceValue)
        {
            if(_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton(instanceValue);
            }
            return _uniqueInstance;
        }
    }
}

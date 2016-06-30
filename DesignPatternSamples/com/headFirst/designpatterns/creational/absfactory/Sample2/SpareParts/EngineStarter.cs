namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    abstract class EngineStarter
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class KeyEngineStarter : EngineStarter
    {
        protected override string getString()
        {
            return "Key Start";
        }
    }

    class AutoEngineStarter : EngineStarter
    {
        protected override string getString()
        {
            return "Auto Start";
        }
    }
}

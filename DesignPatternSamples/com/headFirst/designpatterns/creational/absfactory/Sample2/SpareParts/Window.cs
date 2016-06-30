namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    abstract class Window
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class PowerWindow : Window
    {
        protected override string getString()
        {
            return "Power Window";
        }
    }

    class ManualWindow : Window
    {
        protected override string getString()
        {
            return "Manual Window";
        }
    }
}

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    abstract class Transmission
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class AutoTransmission : Transmission
    {
        protected override string getString()
        {
            return "Auto Transmission System";
        }
    }

    class ManualTransmission : Transmission
    {
        protected override string getString()
        {
            return "Manual Transmission System";
        }
    }
}

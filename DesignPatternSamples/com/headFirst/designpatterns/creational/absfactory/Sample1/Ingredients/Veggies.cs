namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Veggies
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class Garlic : Veggies
    {
        protected override string getString()
        {
            return "Garlic";
        }
    }

    class BlackOlives : Veggies
    {
        protected override string getString()
        {
            return "Black Olives";
        }
    }

    class Eggplant : Veggies
    {
        protected override string getString()
        {
            return "Eggplant";
        }
    }

    class Mushroom : Veggies
    {
        protected override string getString()
        {
            return "Mushroom";
        }
    }

    class Onion : Veggies
    {
        protected override string getString()
        {
            return "Onion";
        }
    }

    class RedPepper : Veggies
    {
        protected override string getString()
        {
            return "RedPepper";
        }
    }

    class Spinach : Veggies
    {
        protected override string getString()
        {
            return "Spinach";
        }
    }
}

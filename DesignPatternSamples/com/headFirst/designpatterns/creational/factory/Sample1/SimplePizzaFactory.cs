namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
{
    class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            var pizzaType = type.ToLower();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}

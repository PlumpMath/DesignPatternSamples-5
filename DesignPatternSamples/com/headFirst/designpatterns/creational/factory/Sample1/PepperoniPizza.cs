namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
{
    class PepperoniPizza : Pizza
    {
        public PepperoniPizza() : base()
        {
            Name = "Papperoni Piza";
            Dough = "Crust";
            Sauce = "Marinara sauce";
            Toppings.Add("Sliced Pepperoni");
            Toppings.Add("Sliced Onion");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}

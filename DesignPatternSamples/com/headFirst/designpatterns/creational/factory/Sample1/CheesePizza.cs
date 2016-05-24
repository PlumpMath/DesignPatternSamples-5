namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
{
    class CheesePizza : Pizza
    {
        public CheesePizza() : base()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}

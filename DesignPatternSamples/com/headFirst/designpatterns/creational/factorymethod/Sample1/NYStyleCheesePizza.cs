namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() : base()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}

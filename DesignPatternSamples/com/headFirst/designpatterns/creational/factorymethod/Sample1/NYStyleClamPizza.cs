namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza() : base()
        {
            Name = "NY Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano Cheese");
            Toppings.Add("Fresh Clams from Long Island Sound");
        }
    }
}

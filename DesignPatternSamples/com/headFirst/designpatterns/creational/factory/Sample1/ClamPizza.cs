namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
{
    class ClamPizza : Pizza
    {
        public ClamPizza() : base()
        {
            Name = "Clam Pizza";
            Dough = "Thin Crust";
            Sauce = "White garlic sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}

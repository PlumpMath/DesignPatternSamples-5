using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    class DecoratorSample1
    {
        public static void Main(string[] args)
        {
            var whiteBreadSandwich = new WhiteBreadSandwich(30);

            var brownBreadSandwich = new BrownBreadSandwich(35);

            var whiteBreadCheeseSandwich = new Cheese(whiteBreadSandwich, 5);

            var whiteBreadDoubleCheeseSandwich = new Cheese(whiteBreadCheeseSandwich, 5);

            var whiteBreadGrilledSandwich = new Grilled(whiteBreadSandwich, 10);

            var whiteBreadCheeseGrilledSandwich = new Grilled(whiteBreadCheeseSandwich, 10);

            var whiteBreadDoubleCheeseGrilledSandwich = new Grilled(whiteBreadDoubleCheeseSandwich, 10);

            var brownBreadCheeseSandwich = new Cheese(brownBreadSandwich, 5);

            var brownBreadDoubleCheeseSandwich = new Cheese(brownBreadCheeseSandwich, 5);

            var brownBreadGrilledSandwich = new Grilled(brownBreadSandwich, 10);

            var brownBreadCheeseGrilledSandwich = new Grilled(brownBreadCheeseSandwich, 10);

            var brownBreadDoubleCheeseGrilledSandwich = new Grilled(brownBreadDoubleCheeseSandwich, 10);

            Console.WriteLine("--------------------MENU-------------------------------");
            Console.WriteLine("No.  Items                                    Price(Rs)");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(" 1. White Bread Sandwich                      {0}", whiteBreadSandwich.ShowPrice());
            Console.WriteLine(" 2. Brown Bread Sandwich                      {0}", brownBreadSandwich.ShowPrice());
            Console.WriteLine(" 3. White Bread Cheese Sandwich               {0}", whiteBreadCheeseSandwich.ShowPrice());
            Console.WriteLine(" 4. Brown Bread Cheese Sandwich               {0}", brownBreadCheeseSandwich.ShowPrice());
            Console.WriteLine(" 5. White Bread Extra Cheese Sandwich         {0}", whiteBreadDoubleCheeseSandwich.ShowPrice());
            Console.WriteLine(" 6. Brown Bread Extra Cheese Sandwich         {0}", brownBreadDoubleCheeseSandwich.ShowPrice());
            Console.WriteLine(" 7. White Bread Grill Sandwich                {0}", whiteBreadGrilledSandwich.ShowPrice());
            Console.WriteLine(" 8. Brown Bread Grill Sandwich                {0}", brownBreadGrilledSandwich.ShowPrice());
            Console.WriteLine(" 9. White Bread Cheese Grill Sandwich         {0}", whiteBreadCheeseGrilledSandwich.ShowPrice());
            Console.WriteLine("10. Brown Bread Cheese Grill Sandwich         {0}", brownBreadCheeseGrilledSandwich.ShowPrice());
            Console.WriteLine("11. White Bread Extra Cheese Grill Sandwich   {0}", whiteBreadDoubleCheeseGrilledSandwich.ShowPrice());
            Console.WriteLine("12. Brown Bread Extra Cheese Grill Sandwich   {0}", brownBreadDoubleCheeseGrilledSandwich.ShowPrice());
            Console.Read();
        }
    }
}

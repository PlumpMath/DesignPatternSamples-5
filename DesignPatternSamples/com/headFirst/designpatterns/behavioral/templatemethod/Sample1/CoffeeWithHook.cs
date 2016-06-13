using System;
using System.IO;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    class CoffeeWithHook : CoffeeBeverageWithHook
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override bool customerWantsCondiments()
        {
            var ans = getUserInput();

            if (ans.ToLower().StartsWith("y"))
                return true;
            else
                return false;
        }

        private string getUserInput()
        {
            var answer = string.Empty;

            Console.Write("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException)
            {
                Console.WriteLine("IO error trying to read your answer");
            }

            if (string.IsNullOrWhiteSpace(answer))
                return "no";

            return answer;
        }
    }
}

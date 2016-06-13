using System;
using System.IO;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    class TeaWithHook : CoffeeBeverageWithHook
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void brew()
        {
            Console.WriteLine("Steeping the tea");
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

            Console.Write("Would you like lemon with your tea (y/n)? ");

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

using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class Screen
    {
        private string _description;

        public Screen(string description)
        {
            _description = description;
        }

        public void Up()
        {
            Console.WriteLine("{0} going up", _description);
        }

        public void Down()
        {
            Console.WriteLine("{0} going down", _description);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

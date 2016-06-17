namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}

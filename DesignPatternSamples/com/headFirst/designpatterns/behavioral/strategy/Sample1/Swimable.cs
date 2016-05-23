using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    class Swimable : ISwimable
    {
        private string _name;

        public Swimable(string name)
        {
            _name = name;
        }

        public bool CanSwim
        {
            get
            {
                return true;
            }
        }

        public void Swim()
        {
            Console.WriteLine("{0} can swim.", _name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    interface ISwimable
    {
        void Swim();

        bool CanSwim { get; }
    }
}

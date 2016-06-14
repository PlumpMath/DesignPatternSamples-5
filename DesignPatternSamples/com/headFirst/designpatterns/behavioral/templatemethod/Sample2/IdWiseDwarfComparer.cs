using System;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample2
{
    class IdWiseDwarfComparer : IComparer<UncomparableDwarf>
    {
        public int Compare(UncomparableDwarf x, UncomparableDwarf y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}

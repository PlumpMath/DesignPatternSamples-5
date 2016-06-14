using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample2
{
    class NamewiseDwarfComparer : IComparer<UncomparableDwarf>
    {
        public int Compare(UncomparableDwarf x, UncomparableDwarf y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

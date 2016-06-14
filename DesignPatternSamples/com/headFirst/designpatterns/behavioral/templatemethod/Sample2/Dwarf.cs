using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample2
{
    sealed class Dwarf : IComparable
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var otherDwarf = obj as Dwarf;

            if (otherDwarf != null)
                return Name.CompareTo(otherDwarf.Name);
            else
                throw new ArgumentException("Object is not Dwarf");
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample2
{
    class TemplateMethodSample2
    {
        static void Main(string[] args)
        {
            var sevenDwarfs = new Dwarf[7];

            sevenDwarfs[0] = new Dwarf() { Name = "Sleepy", Id = 1 };
            sevenDwarfs[1] = new Dwarf() { Name = "Bashful", Id = 2 };
            sevenDwarfs[2] = new Dwarf() { Name = "Doc", Id = 3 };
            sevenDwarfs[3] = new Dwarf() { Name = "Dopey", Id = 4 };
            sevenDwarfs[4] = new Dwarf() { Name = "Happy", Id = 5 };
            sevenDwarfs[5] = new Dwarf() { Name = "Sneezy", Id = 6 };
            sevenDwarfs[6] = new Dwarf() { Name = "Grumpy", Id = 7 };

            Array.Sort(sevenDwarfs);

            DisplayDwarfs(sevenDwarfs);

            Console.Read();
        }

        static void DisplayDwarfs(Dwarf[] dwarfs)
        {
            foreach(var dwarf in dwarfs)
            {
                Console.WriteLine("{0}\t{1}", dwarf.Name, dwarf.Id);
            }
        }
    }
}

using System;
using System.IO;
using System.Linq;

namespace NameSorter
{
    public class NameSorter
    {
        static void Main(string[] args)
        {
            if (args[0].ToString() !="")
            {
                //"unsorted-names-list.txt"
                string[] lines = File.ReadAllLines(@args[0].ToString());
                SortByLastName(lines);
            }
        }

        public static void SortByLastName(string[] lines)
        {
            
            var result = lines.AsParallel()
                .OrderBy(s => s.Split(' ').Last())
                .ToList();
            result.ForEach(i => Console.Write("{0}\n", i));
            using (TextWriter tw = new StreamWriter(@"sorted-names-list.txt"))
            {
                foreach (String s in result)
                    tw.WriteLine(s);
            }
        }
    }
}

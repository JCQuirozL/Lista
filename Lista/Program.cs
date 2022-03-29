using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "A","B","C","D","E","F"};
            List<string> list2 = new List<string> { "B","E","G","H","I","J" };
            List<string> list3 = new List<string>();
            var primera = list1.Where(i => !list2.Contains(i)).ToList();
            var segunda = list2.Where(i => !list1.Contains(i)).ToList();
            Console.WriteLine("En Lista1 no en Lista2");
            foreach (var x in primera)
            {
                list3.Add(x);
                Console.WriteLine(x);
            }
            Console.WriteLine("En Lista2 pero no en Lista1");
            foreach (var y in segunda)
            {
                Console.WriteLine(y);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista3 = new List<string>();
            List<string> Lista1 = new List<string> { "A", "B", "C", "D", "E", "F" };
            List<string> Lista2 = new List<string> { "B", "E", "G", "H", "I", "J" };

            
            for (int i = 0; i < Lista1.Count; i++)
            {
                              
                    if (Lista1[i] == Lista2[i])
                    {
                        Lista3.Add(Lista1[i].ToString());
                        Console.WriteLine(Lista3[i].ToString());
                    }
                                
            }
        }
    }
}

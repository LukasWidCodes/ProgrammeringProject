using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> översättning = new Dictionary<string, string>();
            //översättning.Add("hej", "hello");
            //översättning.Add("mus", "mouse");
            //översättning.Add("dator", "computer");
            //översättning.Add("tangentbord", "keyboard");
            //Console.WriteLine(översättning["hej"]);

            Console.WriteLine("Skriv en mening");
            string[] mening = Console.ReadLine().Split();

            Dictionary<string, int> minDictionary = new Dictionary<string, int>();

            foreach (string m in mening) 
            { 
                if (minDictionary.ContainsKey(m))
                {
                    minDictionary[m]++;
                }
                else
                {
                    minDictionary.Add(m, 1);
                }
            }

            foreach(var m in minDictionary)
            {
                if (m.Value == 2 || m.Value ==3)
                {
                    Console.WriteLine($"Ordet {m.Key} förekommer {m.Value} gånger");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OOP3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<List<string>, int> dict = new Dictionary<List<string>, int>();
            dict.Add(new List<string> { "a", "b", "l", "y", "q" }, 1);
            dict.Add(new List<string> { "s", "b", "x", "z", "q" }, 2);
            dict.Add(new List<string> { "d", "b", "f", "a", "w" }, 3);
            dict.Add(new List<string> { "m", "p", "r", "z", "e" }, 1);

         
          
          

            SortKeys(dict.Keys.ToList());

          
      

            Console.ReadLine();


            void SortKeys(List<List<string>> a)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Sort();

                }
            };
        }
    }
}

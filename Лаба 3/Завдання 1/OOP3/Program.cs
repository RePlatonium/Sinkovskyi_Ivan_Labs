using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<int> nums = new HashSet<int>();
            SortedSet<int> numS = new SortedSet<int>();
            ArrayList numAL = new ArrayList();
            LinkedList<int> numLL = new LinkedList<int>();
            Stopwatch stopWatch = new Stopwatch();



            int count = 100000;
            int[] array1 = new int[count];
            Random rand1 = new Random();
            for (int i = 0; i < array1.Length; i++) array1[i] = rand1.Next(0,1000);
            Console.WriteLine("count={0}", count);
            Console.WriteLine("--------------------------");
            stopWatch.Start();
            nums.UnionWith(array1);

            stopWatch.Stop();
            Console.WriteLine("Додавання HashSet:{0} мс", stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();
           
            stopWatch.Start();

           nums.Contains(rand1.Next());

            stopWatch.Stop();
            Console.WriteLine("Пошук HashSet:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Reset();

            stopWatch.Start();

            nums.Remove(rand1.Next());

            stopWatch.Stop();
            Console.WriteLine("Видалення HashSet:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Reset();
            Console.WriteLine("--------------------------");
            stopWatch.Start();

            numS.UnionWith(array1);

            stopWatch.Stop();

            Console.WriteLine("Додавання SortedSet:{0} мс", stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();

            stopWatch.Start();

            numS.Contains(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Пошук SortedSet:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();


            stopWatch.Start();

            numS.Remove(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Видалення SortedSet:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();
            Console.WriteLine("--------------------------");
            stopWatch.Start();

            numAL.AddRange(array1);

            stopWatch.Stop();

            Console.WriteLine("Додавання ArrayList:{0} мс", stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
          
            stopWatch.Start();

            numAL.Contains(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Пошук ArrayList:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();
            stopWatch.Start();

            numAL.Remove(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Видалення ArrayList:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();
            Console.WriteLine("--------------------------");
             stopWatch.Restart();
       
            stopWatch.Start();

            for(int i = 0; i < array1.Length; i++)
            {
                numLL.AddLast(array1[i]);
            }

            stopWatch.Stop();

            Console.WriteLine("Додавання LinkedList:{0} мс", stopWatch.ElapsedMilliseconds);
            stopWatch.Restart();
            stopWatch.Start();

            numLL.Contains(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Пошук LinkedList:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();

            stopWatch.Start();

            numLL.Remove(rand1.Next());

            stopWatch.Stop();

            Console.WriteLine("Видалення LinkedList:{0} мс", stopWatch.ElapsedTicks * 427.0 / 1000000.0);
            stopWatch.Restart();

            Console.ReadLine();

        }
    }
}

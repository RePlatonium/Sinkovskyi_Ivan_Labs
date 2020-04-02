using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "dasdas", "sdsadsd", "ka", "qwee", "upou", "mnl","jklkas" };
            var list=str.ToList();
            list[0]=list[0].First().ToString();
           

           
            string result =list.Aggregate((x,y)  => x + y.First().ToString() );


          
           Console.WriteLine( result);
            Console.ReadLine();







        }
    }
}

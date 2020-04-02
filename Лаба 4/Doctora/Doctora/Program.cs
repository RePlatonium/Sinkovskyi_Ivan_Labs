using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctora
{
    class Program
    {
        abstract class doctor
        {
            int salary;
            int practise;
             public doctor(int Salary,int Practise)
            {
                salary = Salary;
                practise = Practise;
            }
            public void ShowPractice()
            {
                Console.WriteLine(practise);
            }
        }
        interface teethDoctor
        {
            int payment(int teeth );
        }

        class surgeon : doctor
        {

            public surgeon(int s,int p) : base(s, p) {}
           
        }
        class neurosurgeon : doctor
        {

            public neurosurgeon(int s, int p) : base(s, p) {}


        }

        class dentist : doctor,teethDoctor
        {

            public dentist(int s, int p) : base(s, p){}
            public int payment(int work)
            {
                return work * 300;
            }
        }

        class dentalTech : doctor,teethDoctor
        {

            public dentalTech(int s, int p) : base(s, p) {}
          
            public int payment(int work)
            {
                return work *1000;
            }
        }
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
    }
}

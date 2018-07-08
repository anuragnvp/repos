using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphis
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Employee();
            Employee FTE = new FullTimeEmployee();
            Employee PTE = new PartTimeEmployee();
            FTE.FirstName = "Anurag";
            FTE.LastName = "Gupta";
            //FTE.gender = "Male";
            //FTE.AnnualSalary = 20000;
            //int monthlysalary=FTE.GetMonthlySalary();
            //Console.WriteLine("MOnthly salary for full time employee\t{0}\t{1} is={2} and
            //gender is={3}", FTE.FirstName, FTE.LastName, monthlysalary,FTE.gender);
            ee.PrintFullName();
            PTE.PrintFullName();
            FTE.PrintFullName();
            Console.ReadLine();
        }
    }
    class Employee
    {
        public string FirstName;
        public string LastName;
        //public string gender;
        public virtual void PrintFullName()
        {
            Console.WriteLine("Full name of employee is={0} {1}", FirstName, LastName);
        }

    }
    class FullTimeEmployee: Employee
    {
        //public int AnnualSalary=0;
        // public int GetMonthlySalary()
        // {

        //     return AnnualSalary / 12;
        // }
        public override void PrintFullName()
        {
            Console.WriteLine("Full name of employee is={0} {1}", FirstName, LastName + "-Full Time Employee");
        }
    }
    class PartTimeEmployee: Employee
    {
       //public int HourlySalary;
       // public int WorkingHours;
       // public int GetHourlySalary()
       // { return HourlySalary * WorkingHours; }
        public override void PrintFullName()
        {
            Console.WriteLine("Full name of employee is={0} {1}", FirstName, LastName+"-Parttime employee");
        }

    }


}
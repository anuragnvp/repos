using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public static void Main()
        {
             List<Employee> emplist= new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "anurag", Experience = 6, Salary = 5000 });
            emplist.Add(new Employee() { ID = 102, Name = "rishi", Experience = 6, Salary = 6000 });
            emplist.Add(new Employee() { ID = 103, Name = "vishal", Experience = 4, Salary = 7000 });
            emplist.Add(new Employee() { ID = 104, Name = "shivi", Experience = 5, Salary = 8000 });
            
           // DelegateSample obj = new DelegateSample(Promote);
            Employee.PromoteEmployee(emplist,emp=> emp.Experience>4);//lamda expression
            Console.ReadLine();
        }
        //public static bool Promote(Employee emp)
        //{
        //    if(emp.Experience>5)
        //    { return true; }
        //    else
        //    { return false; }
        //}
    }
    delegate  bool DelegateSample(Employee emp1);
    class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, DelegateSample Ispromotable)
        {
            foreach (Employee employee in employeeList)
            {
                if (Ispromotable(employee))
                {
                    Console.WriteLine("Employee ID={0} Name={1}  Salary={2} Experience={3}",
                    employee.ID, employee.Name, employee.Salary, employee.Experience);

                }
            }
            
        }
    }
}

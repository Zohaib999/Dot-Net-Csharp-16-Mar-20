using System;
using System.Collections.Generic;
namespace DelegateAdvance
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { id=1, Name="Zohaib", Salary= 12, Experience= 12}); 
            employees.Add(new Employee { id=2, Name="Suleman", Salary= 12, Experience= 2}); 
            employees.Add(new Employee { id=3, Name="Saad", Salary= 12, Experience= 16}); 
            employees.Add(new Employee { id=4, Name="Faiz", Salary= 12, Experience= 5});

            //Employee.Promote(employees);       Hard Coded 

            //                                   DELEGATE Method
            //Ispromoted D_ispromoted = new Ispromoted(Ispromoted);
            //Employee.Promote(employees, D_ispromoted);    


            //                                   Lamda Expression
            Employee.Promote(employees, emp => emp.Experience >= 5);



            bool Ispromoted(Employee employee)
            {
                if(employee.Experience >= 5) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
 delegate bool Ispromoted(Employee employee);

class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promote(List<Employee> employeeslist, Ispromoted ispromoted)
        {
          foreach(var Employee in employeeslist)
            {
                //if(Employee.Experience >= 5 )   HARD CODEED FORM
                if(ispromoted(Employee))
                {
                    Console.WriteLine(Employee.Name+"       xIs PROMOTED");
                }
            }
        }
    }
}

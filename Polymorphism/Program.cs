using System;

namespace Polymorphism
{
   class Employee
    {
       public virtual void Print()
        {
            Console.WriteLine("Simple Employee");
        }
    }
    class FullTimeEmployee:Employee
    {
        public override void Print()
        {
            Console.WriteLine("Full Time  Employee");
        }
    }
    class PartTimeEmployee:Employee
    {
        public override void Print()
        {
            Console.WriteLine("Part time Employee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee ob = new PartTimeEmployee();
            ob.Print();
        }
    }
}

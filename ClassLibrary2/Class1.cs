using System;
using ClassLibrary1; 

namespace ClassLibrary2
{
    public class Class1:AssemblyClass1
    {
        public void Print()
        {
            AssemblyClass1 ob = new AssemblyClass1();
            Console.WriteLine(base.Id);
        }

    }
}

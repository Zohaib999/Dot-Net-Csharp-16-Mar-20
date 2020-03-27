using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpInheritance
{
    class Parent
    {
        public string name="Child class";
        //consructor of Parent 
        public void P_Method()
        {
            Console.WriteLine("This is Parent class");
            Child ob = new Child();
            ob.C_Method(name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Lec3
    {

        //built in Types in C#
        public void CoutAge()
        {
            string a = "Please Enter you name ";
            Console.WriteLine(a);
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter your age");
            int? x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("hello {0}, your age is {1}", name  ,x);


            bool chk = x > 18 ? true : false;
            if(chk)
            {
                Console.WriteLine("You are Adult");
            }
            else
            {
                Console.WriteLine("You are child");
            }








        }
    }
}

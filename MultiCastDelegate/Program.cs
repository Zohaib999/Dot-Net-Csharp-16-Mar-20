using System;

namespace MultiCastDelegate
{
    delegate void Mutidelegate();
    class Program
    {
        static void Main(string[] args)
        {
            // void method will save the method object in a Collection List
            Mutidelegate ob0 = new Mutidelegate(d1);
            Mutidelegate ob1 = new Mutidelegate(d2);
            Mutidelegate ob2 = new Mutidelegate(d3);

            Mutidelegate Total = ob0 + ob1 + ob2;
            Total();
           
            //We can also do subtration in delegate as well
            Mutidelegate Total1 = ob0 + ob1 + ob2 -ob1;
            Total1();


        }
        public static void d1()
        {
            Console.WriteLine("Delegate No. one ");
        }
        public static void d2()
        {
            Console.WriteLine("Delegate No. Two");
        }
        public static void d3()
        {
            Console.WriteLine("Delegate No. Three ");
        }

    }
}

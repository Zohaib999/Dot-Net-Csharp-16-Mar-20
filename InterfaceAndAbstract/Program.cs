using System;

namespace InterfaceAndAbstract
{
    //Abstract Implementation
    public abstract class calculate
    {
        public int sum(int a, int b) 
        {
            int sum = a + b;
            return sum;
        }
    }

    class Program:calculate
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            int x = ob.sum(10, 20);
            Console.WriteLine("Hello abstrct  Sum ====>  " + x);
        }
    }
}

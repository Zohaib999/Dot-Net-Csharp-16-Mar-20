using System;

namespace InterfaceAndAbstract
{
    //Abstract Implementation
    public abstract class calculate
    {
        public string sum(int a, int b)
        {
            int sum = a + b;
            string ans = "Sum in Parent class " + sum;
            return ans;
        }
    }
    public abstract class Solve : calculate
    {
        public new string sum(int a, int b)
        {
            int sum = a + b;
            string ans = "Sum in Child class "+sum;
            return ans;
        }

    }

    class Program: Solve
    {
        static void Main(string[] args)
        {
            Solve ob = new Program();
            string a = ob.sum(10, 20); 
            Console.WriteLine(a);
        }
    }
}

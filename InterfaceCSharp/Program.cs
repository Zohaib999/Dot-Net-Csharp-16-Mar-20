using System;

namespace InterfaceCSharp
{

    public interface isum
    {
        public void sum(int x, int y);
    }

    class Program:isum
    {
        public void sum(int x, int y)
        {
            Console.WriteLine("Hello from Sum Interface  \n   sum =  "+(x+y));
        }
        static void Main(string[] args)
        {

            Program ob = new Program();
            ob.sum(10,20);
        }
    }
}

using System;

namespace DelegateInCSharp
{

    public  delegate void  D_Method();
    class Program
    {
        static void Main(string[] args)
        {
            D_Method ob = new D_Method(Message);
            ob();

        }
        public static void Message()
        {
            string ans = "Hello Welocome to the Delegates";
            Console.WriteLine(ans);
        }
    }

}

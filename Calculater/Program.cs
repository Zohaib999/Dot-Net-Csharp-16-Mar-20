using System;
using Sum;
namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Write a number that can be used to sum");
            int a = int.Parse(Console.ReadLine());
            sum obRefernce = new sum(ref a);

            Sum.sum ob3 = new Sum.sum();
            Sum.sum ob = new Sum.sum("Hell", "World");
            Sum.sum ob2 = new Sum.sum(2,4,5);

            //out parameter
            int ans = 0;
            int SaveAns = 0;
            sum Obans = new sum(1, 2,out ans , out SaveAns );

        }
    }
}
// namespace Constructor 
namespace Sum
{
    class sum
    {  
        string a = "";
        string b = "";
        public sum(string x, string y)
        {
            a = x;
            b = y;
            Console.WriteLine("     Sum is equal  "+(a+b));
        }
        //Constructor overloading 
        //Sum with three digits
        public sum(int a, int b, int c)
        {
            Console.WriteLine("     \n Sum with three digits "+(a+b+c));
        }

        //static Constructor 
        //this will run at number 1
        public sum()
        {
            Console.WriteLine("\n hello this is static constructor \n");
        }
        //Empty constructor but with a refernece 
        //reference Virable Constructor
        public sum(ref int a)
        {
            Console.WriteLine("this is a referncing Constructor");
            a = 0;
            Console.WriteLine("Constructor that is referncing "+a);
        }
        public sum(int a, int b, out int ans, out int product)
        {
            ans = a + b;
            product = a * b;
            Console.WriteLine("Sum is " +ans);
            Console.WriteLine("Prosuct is " +product);
        }


    }
}
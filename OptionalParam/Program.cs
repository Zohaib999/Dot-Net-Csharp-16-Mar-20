using System;

namespace OptionalParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10,20,30);
            //We can add other numbers as  well but it is not necessary
            Add(10,20,30,40);
            //We can also pass an array with an undefined number
            Add(10, 20,new object[] { 30, 40 , 50, 60});




            //Optional Parameter Using Method Overloading
            Console.WriteLine(" \n Optional Parameter Using Method Overloading");
            Add(10,20);




        }

        public static void Add(int a,int b,params object[] RestoftheNumbers)
        {
            int sum = a + b;
            if (RestoftheNumbers != null) 
            { 
            foreach(int i in RestoftheNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum is "+sum);
        }

        //optional paramter using method overloading
        //now we did not need any third parameter
        //it can be optional
        public static void Add(int a,int b)
        {
            Add(a, b, null);
        }
    }
}

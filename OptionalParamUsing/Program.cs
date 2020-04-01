using System;

namespace OptionalParamUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //             optional paramter by passing null
            //Console.WriteLine("Optional paramter by passing null ");
            //Add(10, 20, 30);


            //              Passing Default value
            Console.WriteLine("Passing Default Value");
            Add(10,50);



        }


        public static void Add(int a, int b, int c, int[] d = null)
        {
            try
            { 
                Console.WriteLine("Passing null value in to make it optional ");
                
                int sum = a + b + c;
                if (d != null)
                {
                    foreach (int restoftheNum in d)
                    {
                        sum += restoftheNum;
                    }
                }
                Console.WriteLine("sum = "+sum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //sum with 3 numbers with 2 default values
        public static void Add(int a,int b= 10, int c= 20)
        {
            Console.WriteLine("First Number"+a);
            Console.WriteLine("First Number"+b);
            Console.WriteLine("First Number"+c);
            int sum = a + b + c;
            Console.WriteLine("Sum is " + sum);
        }
}
}

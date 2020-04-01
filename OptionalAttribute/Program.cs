using System;
using System.Runtime.InteropServices;

namespace OptionalParamAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 20);
        }
        public static void Add(int a, int b, [Optional] int[] RestofTheNumbers)
        {
            int sum = a + b;
            if(RestofTheNumbers != null)
            { 
                foreach (int Number in RestofTheNumbers)
                {
                    sum += Number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

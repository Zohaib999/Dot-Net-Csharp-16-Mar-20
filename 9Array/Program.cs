using System;

namespace _9Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Products = new string[11];
            for(int i=1; i<11; i++)
            {
                Console.WriteLine("Enter product Name for number  " + i);
                Products[i] = Console.ReadLine();
            }
            Console.WriteLine("Press 1 to view code");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x==1)
            {
                foreach (var product in Products)
                {
                    Console.WriteLine(product);
                }
            }

        }
    }
}

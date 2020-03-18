using System;

namespace Whileloop_Dowhile
{
    class Program
{
    static void Main(string[] args)
    {
            start:
            //while loop
            Console.WriteLine("Enter the No. value to you want to store");
            int n = int.Parse(Console.ReadLine());
            string[] Products = new string[n];
            int i = 1;
            while (i<n)
            {
                
                Console.WriteLine("Please Enter the Name of the product \n" + i);
                Products[i] = Console.ReadLine();
                i++;
            }
            string ans = string.Empty;
            do
            {
                Console.WriteLine("Do You want to add more products \n" +
                "press Yes to add or No to exit ");
                ans = Console.ReadLine();
                if(ans=="yes") 
                    goto start;
            } while (ans == "No");




    }
}
}

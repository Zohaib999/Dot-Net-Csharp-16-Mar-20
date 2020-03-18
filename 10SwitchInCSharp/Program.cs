using System;

namespace _10SwitchInCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
            start:
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the product you want to purhase");
            Console.WriteLine("1-Shirt \n 2-Pants \n 3-others");
            int n = int.Parse(Console.ReadLine());
           
            switch (n)
            {
                case 1:
                    Console.WriteLine("1 Small ===> Rs 1000");
                    Console.WriteLine("Press 1 to purchase or 0 to exit");
                    int order = int.Parse(Console.ReadLine());
                    if (order == 1)
                        amount(1000);
                    break;

                case 2:
                    Console.WriteLine("2 Large ===> Rs 2000");
                    Console.WriteLine("Press 1 to purchase or 0 to exit");
                     order = int.Parse(Console.ReadLine());
                    if (order == 1)
                        amount(2000);
                    break;
                default:
                    Console.WriteLine("You Entered an invalid no." +
                        "please try again");
                    goto start;
            };

            static void amount(int amount)
            {
                int bill = amount;
                Console.WriteLine(amount);
            }


        }
    }
}

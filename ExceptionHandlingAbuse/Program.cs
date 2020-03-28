using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.WriteLine("Enter a Number");
                int num;
                bool numIsSucessful = int.TryParse(Console.ReadLine(),out num);

                if (numIsSucessful)
                {
                    Console.WriteLine("Enter b Number");
                    int denum;
                    bool denumIsSucessful = int.TryParse(Console.ReadLine(), out denum);
                    if (denumIsSucessful && denum != 0)
                    {
                        int total = num / denum;
                        Console.WriteLine("Division is "+ total);
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Number");
                        goto start;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                    goto start;
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

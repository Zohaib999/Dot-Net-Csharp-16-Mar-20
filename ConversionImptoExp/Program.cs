using System;

namespace ConversionImptoExp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit and Explicit
            //Implicit means small to large e.g int to float
            int a = 10;
            float b = a;
            Console.WriteLine("\n"+b+"\n");

            //Conversion of string from to int
            string  Number = "11";
            int No = int.Parse(Number);
            Console.WriteLine(No + "\n");

            //Diff between Parse & TryParse
            //Parse only convert the number
            string x = "20";
            int y = int.Parse(x);
            Console.WriteLine(x + "\n");

            //Tryparse convert the no. from string to int but also check and 
            // save the no. in another variable
            string d = "20f";
            int k = 0;
            bool s = int.TryParse(d, out k );
            if (s == true)
            {
                Console.WriteLine("Conversion Sucessfull");
            }
            else
            {
                Console.WriteLine("You Entered a wrong No");
            }
        }
    }
}

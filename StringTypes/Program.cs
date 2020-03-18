using System;

namespace StringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple string
            string a = "Hello from String";
            Console.WriteLine(a);

            //Escape Sequence 
            string b = "\"This is Escape Sequence\"";
            Console.WriteLine(b);

            //Verbetim Literial  
            string c = @"this is Verbetiam literal in which we write doube slash in as 
                            follows  ";
            Console.WriteLine(c);
        }
    }
}

using System;
using System.IO;

namespace ExceptionHanding
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to divide");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b number to divide");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Answe of divide is  "+c);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message); 
                Console.WriteLine(ex.StackTrace); 
            }
            
            //file Reader Exception
            try
            {
                //Directory Does not exist
                StreamReader ob = new StreamReader(@"G:\data.txt");
                Console.WriteLine(ob.ReadToEnd());
                ob.Close();

            }
            //Real time Inheritance Exception
            //Child class 
            //the console check the file in the Child Class First 
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check " + ex.Message);
               
            }
            //Parent class 
            //If file is not found then it will find it in the parent class 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            // e has fiels in it like e.message which dispys the message
            // e.stacktrace which shows the line no. 
            // etc and much more like e.data
            }
            //finally block always execute
            //it is used to close the resources 
            finally
            {
                Console.WriteLine("Finally block ");
            }

        }
    }
}

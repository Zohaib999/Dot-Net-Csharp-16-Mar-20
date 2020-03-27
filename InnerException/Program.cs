using System;
using System.IO;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first Number");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int b = int.Parse(Console.ReadLine());

                    int c = a / b;
                    Console.WriteLine("Answer is " + c);
                }
                catch (Exception ex)
                {
                    string path = @"C:\Users\Zohaib\Desktop\Paractice\Notes\1 C#\C#-practice\InnerException\bin\Debug\netcoreapp3.1\log1.txt";
                    
                    if (File.Exists(path))
                    {
                        
                        StreamWriter streamWriter = new StreamWriter(path);
                        streamWriter.Write(ex.GetType().Name+ex.Message+ex.StackTrace);
                        streamWriter.Close();
                        Console.WriteLine("there is an error please try again later");
                    }
                    else
                    {
                        
                        throw new FileNotFoundException(path+"Does not Exist"+ ex);
                    }
                }
            }
            catch (Exception e)
            {
                //it shows outer Exception
                Console.WriteLine("\n Current or Outer Exception \n "+e.Message);

                //Inner Exception
                if (e.InnerException != null)
                {
                    Console.WriteLine("\n Inner Exception");
                    Console.WriteLine(e.InnerException.Message + e.StackTrace);
                }

            }
            
            
        }
    }
}

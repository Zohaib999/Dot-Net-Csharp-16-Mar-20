using System;
using System.IO;

class InnerException
{
    public static void main(String args[])
    {
        try
        {
            try
            {

                Console.WriteLine("Enter Enumenator  ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denumenator");
                int b = int.Parse(Console.ReadLine());

                int div = a / b;
                Console.WriteLine("Division is " + div);


            }

            catch (Exception ex)

            
            {
                //we want to save the error in the database 
                //But File Not exist in the computer
                String Path = @"C:/data/log.txt";

                if (File.Exists(Path))

                {

                    StreamWriter StrRed = new StreamWriter(Path);
                    StrRed.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                    StrRed.Close();
                    Console.WriteLine("There is a problem please try again");

                }
                else
                {          //this will automatically call the outer exception

                    throw new FileNotFoundException(Path + " Does not Exist", ex);

                }

            }

        }
        catch (Exception e)
        {
            // this will display the outer exception or current exception  
            // File Does not exist
            Console.WriteLine(e.Message);


            // For the innner exception we have to use the InnerException Function of the C#
            if (e.InnerException != null)
            {
                Console.WriteLine(e.InnerException.Message + "\n"); ;
            }
        }
    }

}
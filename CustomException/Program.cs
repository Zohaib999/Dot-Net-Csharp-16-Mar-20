using System;
using System.IO;
using System.Runtime.Serialization;

namespace CustomExceptionClass
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                throw new UseralreadyLogIn("This is Custom Exception");
            }   
            catch (UseralreadyLogIn ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }



    [Serializable]
    //Custom Exception          that is defined by the user
    class UseralreadyLogIn : Exception
    {
        public UseralreadyLogIn():base()
        {
        }
        public UseralreadyLogIn(string message)
            :base(message)
        { 
        }
        public UseralreadyLogIn(string message,Exception innerException) 
            : base(message, innerException)
        {

        }
        
        public UseralreadyLogIn(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {

        }

    }
}

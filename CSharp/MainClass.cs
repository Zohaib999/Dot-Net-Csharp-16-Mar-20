using System;

namespace CSharp
{
    class MainCLass
    {
      public static void Main(string[] args)
        {
            //Lec2 ob = new Lec2();
            //ob.My();

            //Lec3 ob = new Lec3();
            //ob.CoutAge();


            Console.WriteLine("Please Enter your Order");
            int? order = Convert.ToInt32(Console.ReadLine());
            Lec4 ob = new Lec4();
            ob.ChkTicket(order);



        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Lec4
    {
        //nullable 
        public void ChkTicket(int? req)
        {
            int? avialable = 20;
           
            for (; ; )
            {
                int i = 1;
                if (i > 0)
                {
                    avialable = avialable - req;
                    Console.WriteLine("Remaining Orders"+avialable);
                    Console.WriteLine("Press 0 to exit or type any key to odrer again");
                    int? x = Convert.ToInt32(Console.ReadLine());
                    if (x == 0 && avialable>0)
                        break;
                    i++;
                }
            }
            
            

        }
    }
}

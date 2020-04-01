using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
           bool result = CalcuateWithObject.CompareNumber(10,20);
            if (result)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


            // calling function using Generic

            bool[] arr = new bool[3];
            arr[0] = CalculatewithGeneric.CompareNumber<int>(10, 20);
            arr[1] = CalculatewithGeneric.CompareNumber<string>("10","20");
            arr[2] = CalculatewithGeneric.CompareNumber<string>("abc","abc");

            foreach (bool a in arr)
            {

                if (a)
                {
                    Console.WriteLine("Are Equal");
                }
                else
                {
                    Console.WriteLine("Not Equal");
                }
            }


        }
    }
}
//Without Generic Using Object
//but it decrease the performace of the program
class CalcuateWithObject
{
    public static bool CompareNumber(object a, object b)
    {
        return a == b;
    }
}
class CalculatewithGeneric 
{
        //for Generic We use a <T> or any cahracter for making it Generic but it 
        //should be inside the <>
    
        //<T> can come after the class name or method name
    public static bool CompareNumber<T>(T a, T b)
    {
        //For Generic we have to use defined  functions of the genric 
        return a.Equals(b);
    }
}




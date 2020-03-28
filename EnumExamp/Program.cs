using System;

namespace EnumExamp
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] a = (short[])Enum.GetValues(typeof(Gender));
            foreach (var value in a) 
            { 
            Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (var Name in Names)
            {
                Console.WriteLine(Name);
            }

            //We can assign an enum a value.
            Name name = (Name)Gender.Male;

            //we can also use the enum for comparison of the two name
            Name name1 = (Name)Gender.Male;


        }
    }
}
//We can define the values of a specific type but that shoud also be defined in the use of it
public enum Gender:short
{
    Unknown = 1,
    Male,
    Female
}
public enum Name
{
    Zohaib,
    Ama,
    Sam
}
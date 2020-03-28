using System;

namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = (int[])Enum.GetValues(typeof(Gender));

            foreach (int value in a)
            {
                Console.WriteLine(value);
            }

            string[] Names = Enum.GetNames(typeof(Gender));
            foreach (string Name in Names)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
public enum Gender
{
    Unknown,
    male,
    Female
}
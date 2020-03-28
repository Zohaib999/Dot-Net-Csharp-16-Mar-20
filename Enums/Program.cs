using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer()
            {
                Name = "Zohaib",
                Gender = Gender.male
            };
            customer[1] = new Customer()
            {
                Name = "Marya",
                Gender = Gender.Female
            };
            customer[2] = new Customer()
            {
                Name = "sam",
                Gender = Gender.Unknown
            };

            foreach (Customer customer1 in customer)
            {
                Console.WriteLine("Name = {0} Gender = {1}",customer1.Name,GetGender(customer1.Gender) );
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid";
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
public class Customer
{
    public string Name { get; set; }
    public Gender Gender;
}
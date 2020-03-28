using System;

namespace WhyEnum
{
    /// <summary>
    /// Hard Codeed Program using constant for gender 
    /// let suppose we need gender for processing so we need strngly typed Constant KNown as Enun 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];
            customer[0] = new Customer()
            {
                id = 1,
                Name = "Zohaib",
                Gender = 1
            };
            customer[1] = new Customer()
            {
                id = 2,
                Name = "Ali",
                Gender = 1
            };
            customer[2] = new Customer()
            {
                id = 3,
                Name = "Hina",
                Gender = 2
            };
            foreach (var Customer in customer) 
            { 
            Console.WriteLine("ID = {0} , Name = {1}, Gender {2}",Customer.id,Customer.Name,GetGender(Customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unkown";
                case 1:
                    return "male";
                case 2:
                    return "Female";
                default:
                    return "Invalid number ";
            }
        }
    }
}
public class Customer
{
    public int id{get; set;}
    public string Name { get; set; }
    public int Gender { get; set; }

}

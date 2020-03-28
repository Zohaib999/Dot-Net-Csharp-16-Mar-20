using System;
using System.Collections.Generic;
namespace TypeAndFied
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, Name = "Zohaib", Email = "a" });

            foreach (var Customer in customers)
            {
                Console.WriteLine(Customer.Id+Customer.Name+Customer.Email);
            }
        }
    }
}
public class Customer
{
    #region Private
    private int _id;
    private string _name;
    private string _email;
    #endregion

    #region Peoperties
    public int Id
    {
        set { _id = value; }
        get { return _id; }
    }
    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }
    public string Email
    {
        set { _email = value; }
        get { return _email; }
    }
    #endregion
}

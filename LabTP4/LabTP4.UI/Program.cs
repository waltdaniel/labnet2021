using TP4.Entities;
using System;
using TP4.Logic;
namespace LabTP4.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customersLogic = new CustomersLogic();
            foreach(Customers c in customersLogic.GetTodos())
            {
                Console.WriteLine(String.Concat("CustomerID: ", c.CustomerID, " Contact name: ", c.ContactName, " Contact Title: ", c.ContactTitle));
            }
            Console.Read();
        }
    }
}

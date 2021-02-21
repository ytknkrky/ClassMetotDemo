using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("New Customer Adding...\r\nAdded : " + customer.Name + " " + customer.Surname + "\r\n~~~~~~~~~~~~~~");
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Customer Deleting...\r\n : " + customer.Name + " " + customer.Surname + "\r\n~~~~~~~~~~~~~~");
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Id : {0}\r\nName : {1}\r\nSurname : {2}\r\nCustomerNumber : {3}\r\nCredit : {4}\r\n~~~~~~~~~~~~~~", customer.CustomerId, customer.Name, customer.Surname, customer.CustomerNumber, customer.Credit);
        }
    }
}

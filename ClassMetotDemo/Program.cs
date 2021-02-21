using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 12345678901;
            customer1.Name = "Luffy";
            customer1.Surname = "Monkey D.";
            customer1.CustomerNumber = 987654321;
            customer1.Credit = 101001000.00;

            Customer customer2 = new Customer();
            customer2.CustomerId = 12345678902;
            customer2.Name = "Zoro";
            customer2.Surname = "Roronoa";
            customer2.CustomerNumber = 987654322;
            customer2.Credit = 999999.99;

            Customer customer3 = new Customer();
            customer3.CustomerId = 12345678903;
            customer3.Name = "Sanji";
            customer3.Surname = "Vinesmoke";
            customer3.CustomerNumber = 987654323;
            customer3.Credit = 888888.88;

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("~~~~~~~~~~~~~~Added()~~~~~~~~~~~~~~");
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);
            Console.WriteLine("~~~~~~~~~~~~~~Deleted()~~~~~~~~~~~~~~");
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerDelete(customer3);
            Console.WriteLine("~~~~~~~~~~~~~~Listed()~~~~~~~~~~~~~~");
            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(customer3);
        }
    }
}

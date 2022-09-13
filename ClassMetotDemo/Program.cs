using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 716842114;
            customer1.CustomerType = " Bireysel";
            customer1.CustomerName = "Özge";
            customer1.CustomerLastName = "Sert";
            customer1.CustomerPhoneNumber = 05412874;

            Customer customer2 = new Customer();
            customer2.CustomerId = 13249797;
            customer2.CustomerType = " Tüzel";
            customer2.CustomerName = "Zorlu";
            customer2.CustomerLastName = "Holding";
            customer2.CustomerPhoneNumber = 05415487;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);
            customerManager.Update(customer2);

            

            Customer[] customers = new Customer[] {customer1, customer2 };
            customerManager.List(customers);




        }
    }
}

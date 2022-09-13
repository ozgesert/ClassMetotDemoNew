using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        private IEnumerable<object> customers;

        public void Add(Customer customer)
        {
            Console.WriteLine(" Eklendi : " + customer.CustomerName + " " + customer.CustomerLastName);

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(" Güncellendi : " + customer.CustomerName + " " + customer.CustomerLastName);

        }


        public void Delete(Customer customer)
        {
            Console.WriteLine(" Silindi : " + customer.CustomerName + " "  +customer.CustomerLastName);

        }

        public void List(Customer[] customers)
        {
           
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " +customer.CustomerLastName );
            }
        }

    }
}

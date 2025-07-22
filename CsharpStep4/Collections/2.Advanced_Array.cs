using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCode
{
    internal class CustomerArrayExample
    {
        public Customer[] customers;
        public int count;

        public CustomerArrayExample(int size)
        {
            customers = new Customer[size];
            count = 0;
        }

        public void AddCustomer(Customer customer)
        {
            if (count < customers.Length)
            {
                customers[count] = customer;
                count++;
            }
            else
            {
                Console.WriteLine("Array is full. Cannot add more customers.");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            for (int i = 0; i < count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    customers[i] = customer;
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }

        public bool CustomerExists(int customerId)
        {
            for (int i = 0; i < count; i++)
            {
                if (customers[i].Id == customerId)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintAllCustomers()
        {
            Console.WriteLine("\nAll Customers:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(customers[i]);
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            CustomerArrayExample customerArray = new CustomerArrayExample(3);

            Customer customer1 = new Customer(1, "pavithra", "pavi@example.com", "1234567890");
            Customer customer2 = new Customer(2, "neeru", "neeru@example.com", "0987654321");
            Customer customer3 = new Customer(3, "suppu", "suppu@example.com", "1234509876");
            Customer customer4 = new Customer(4, "prassu", "prassu@example.com", "0987612345");

            customerArray.AddCustomer(customer1);
            customerArray.AddCustomer(customer2);
            customerArray.AddCustomer(customer3);
            customerArray.AddCustomer(customer4); // This should fail

            // Update customer2
            Customer updatedCustomer2 = new Customer(2, "nandu", "nandu.@example.com", "098-765-4321");
            customerArray.UpdateCustomer(updatedCustomer2);

            // Check if customer exists
            bool exists = customerArray.CustomerExists(2);
            Console.WriteLine($"\nCustomer with ID 2 exists: {exists}");

            // Print all customers
            customerArray.PrintAllCustomers();
        }
    }
}

using CustomerManagement;
using System;
using System.Collections.Generic;

namespace ProjectCode
{
    internal class CustomerDictionaryExample
    {
        // Dictionary to store Customer objects with their ID as the key
        private Dictionary<int, Customer> customers;

        // Constructor to initialize the Dictionary
        public CustomerDictionaryExample()
        {
            customers = new Dictionary<int, Customer>();
        }

        // Add a new customer
        public void AddCustomer(Customer customer)
        {
            if (!customers.ContainsKey(customer.Id))
            {
                customers[customer.Id] = customer;
            }
            else
            {
                Console.WriteLine("Customer already exists.");
            }
        }

        // Update existing customer
        public void UpdateCustomer(Customer customer)
        {
            if (customers.ContainsKey(customer.Id))
            {
                customers[customer.Id] = customer;
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // Check if a customer exists
        public bool CustomerExists(int customerId)
        {
            return customers.ContainsKey(customerId);
        }

        // Remove a customer by ID
        public void RemoveCustomer(int customerId)
        {
            if (customers.ContainsKey(customerId))
            {
                customers.Remove(customerId);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        // Get customer by ID
        public Customer GetCustomerById(int customerId)
        {
            if (customers.TryGetValue(customerId, out Customer customer))
            {
                return customer;
            }
            Console.WriteLine("Customer not found.");
            return null;
        }
    }

    internal class DictionaryProgram
    {
        static void Main(string[] args)
        {
            CustomerDictionaryExample customerDict = new CustomerDictionaryExample();

            Customer customer1 = new Customer(1, "Alice", "alice@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Bob", "bob@example.com", "098-765-4321");

            customerDict.AddCustomer(customer1);
            customerDict.AddCustomer(customer2);

            // Update Bob’s details
            Customer updatedCustomer2 = new Customer(2, "Bobby", "bobby@example.com", "111-111-1111");
            customerDict.UpdateCustomer(updatedCustomer2);

            // Check existence
            Console.WriteLine($"Customer with ID 2 exists: {customerDict.CustomerExists(2)}");

            // Remove Alice
            customerDict.RemoveCustomer(1);

            // Get customer with ID 2
            Customer customer = customerDict.GetCustomerById(2);
            if (customer != null)
            {
                Console.WriteLine($"Customer with ID 2: {customer.Name}, {customer.Email}, {customer.Phone}");
            }
        }
    }
}


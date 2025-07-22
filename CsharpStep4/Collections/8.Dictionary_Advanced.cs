using CustomerManagement;
using System;
using System.Collections.Generic;

namespace ProjectCode
{
    internal class CustomerListExample
    {
        // List to store Customer objects
        private List<Customer> customers;

        // Constructor
        public CustomerListExample()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        /// Add a new customer
        /// </summary>
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        /// <summary>
        /// Update an existing customer by ID
        /// </summary>
        public void UpdateCustomer(Customer customer)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == customer.Id)
                {
                    customers[i] = customer;
                    return;
                }
            }
            Console.WriteLine("Customer not found.");
        }

        /// <summary>
        /// Check if customer exists
        /// </summary>
        public bool CustomerExists(int customerId)
        {
            return customers.Exists(c => c.Id == customerId);
        }

        /// <summary>
        /// Remove a customer by ID
        /// </summary>
        public void RemoveCustomer(int customerId)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }

        /// <summary>
        /// Get customer by ID
        /// </summary>
        public Customer GetCustomerById(int customerId)
        {
            var customer = customers.Find(c => c.Id == customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
            }
            return customer;
        }
    }

    internal class ListProgram
    {
        static void Main(string[] args)
        {
            CustomerListExample customerList = new CustomerListExample();

            Customer customer1 = new Customer(1, "John Doe", "john@example.com", "123-456-7890");
            Customer customer2 = new Customer(2, "Jane Smith", "jane@example.com", "098-765-4321");
            Customer customer3 = new Customer(3, "Jim Brown", "jim@example.com", "555-555-5555");

            customerList.AddCustomer(customer1);
            customerList.AddCustomer(customer2);
            customerList.AddCustomer(customer3);

            // Update
            Customer updatedCustomer2 = new Customer(2, "Jane Updated", "jane.new@example.com", "098-765-4321");
            customerList.UpdateCustomer(updatedCustomer2);

            // Check existence
            Console.WriteLine($"Customer with ID 2 exists: {customerList.CustomerExists(2)}");

            // Remove
            customerList.RemoveCustomer(3);

            // Get
            Customer result = customerList.GetCustomerById(1);
            if (result != null)
            {
                Console.WriteLine($"Customer found: {result.Name}, {result.Email}, {result.Phone}");
            }
        }
    }
}

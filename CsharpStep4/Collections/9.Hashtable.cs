using System;
using System.Collections;

namespace HashTableNamespace
{
    // Hashtable stores key-value pairs; keys must be unique
    class ExampleHashTable
    {
        static void Main()
        {
            // Create a non-generic Hashtable
            Hashtable ht = new Hashtable();

            // Add entries
            ht.Add("pavithra", "8328092935");

            ht.Add(101, "Employee ID with 101");
            ht.Add("Salary", 10000);

            // Accessing values using keys (casting required)
            string phoneNum = (string)ht["pavithra"];
            string description = (string)ht[101];
            int salary = (int)ht["Salary"];

            // Update value by key
            ht[101] = "Employee ID with 101 is available in Hyd";

            // Remove a key-value pair
            ht.Remove("Salary");

            // Add another item
            ht.Add("IsActive", true);

            // Iterate and print all key-value pairs
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key - {entry.Key}, Value - {entry.Value}");
            }

            // Check if a key exists
            if (ht.ContainsKey(101))
            {
                Console.WriteLine(ht[101] + " Available");
            }
        }
    }
}


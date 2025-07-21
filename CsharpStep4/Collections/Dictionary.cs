using System;
using System.Collections.Generic;

namespace DictionaryNamespace
{
    class ExampleDict
    {
        static void Main()
        {
            // Dictionary: key-value pair collection
            Dictionary<int, string> tableContent = new Dictionary<int, string>();

            // 1. Add elements (Create - C)
            tableContent.Add(1, "Chapter 1");
            tableContent.Add(7, "Chapter 2");
            tableContent.Add(21, "Chapter 3");

            // 2. Read elements using keys (Read - R)
            string chapter1 = tableContent[1];
            string chapter2 = tableContent[7];
            string chapter3 = tableContent[21];

            Console.WriteLine($"Chapter for key 1: {chapter1}");
            Console.WriteLine($"Chapter for key 7: {chapter2}");
            Console.WriteLine($"Chapter for key 21: {chapter3}");

            // 3. Check if key exists
            if (tableContent.ContainsKey(7))
            {
                Console.WriteLine("Key 7 exists.");
            }

            // 4. Remove element by key (Delete - D)
            tableContent.Remove(21);

            // 5. Add new element
            tableContent.Add(37, "Chapter 4");

            // 6. Update existing key (Update - U)
            if (tableContent.ContainsKey(7))
            {
                tableContent[7] = "Chapter 2 - Updated";
            }

            // 7. Loop through dictionary (Read - R)
            Console.WriteLine("\nAll chapters in the dictionary:");
            foreach (KeyValuePair<int, string> kvp in tableContent)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
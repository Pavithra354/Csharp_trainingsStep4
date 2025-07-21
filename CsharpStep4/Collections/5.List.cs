using System;
using System.Collections.Generic;

namespace ListNamespace
{
    class ExampleList
    {
        static void Main()
        {
            // 1. Type-Safety: Only integers allowed
            List<int> numbersList = new List<int>();
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            numbersList.Add(50);

            // 2. Dynamic Size: Can grow as needed
            numbersList.Add(60);
            numbersList.Add(70);

            // 3. No Boxing: Value types are stored directly
            int first = numbersList[0];

            // 4. Multiple data types not allowed (Type-safe)
            // numbersList.Add("Hello");  // ❌ Compile-time error
            // numbersList.Add(true);     // ❌ Compile-time error

            // 5. Looping through the list
            Console.WriteLine("List Elements:");
            foreach (int num in numbersList)
            {
                Console.WriteLine(num);
            }

            // 6. Performance Example: Adding 1000 items
            List<int> list1000Items = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                list1000Items.Add(i); // Efficient, no boxing
            }

            // Accessing a value
            int value = list1000Items[100];
            Console.WriteLine($"Item at index 100: {value}");
        }
    }
}
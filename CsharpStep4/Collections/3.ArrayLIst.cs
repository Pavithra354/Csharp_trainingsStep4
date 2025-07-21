using System;
using System.Collections;

namespace ArrayListNamespace
{
    class ExampleArrayList
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            // 1. Not Type-Safe (can store any data type)
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add("Hello");
            arrayList.Add(false);

            // 2. ArrayList Dynamic Size  
            arrayList.Add(10);         // Index 0
            arrayList.Add(20);         // Index 1
            arrayList.Add("Hello");    // Index 2
            arrayList.Add(false);      // Index 3
            arrayList.Add(20);         // Index 4

            // 3. Object to expected datatype (Unboxing)
            int first = (int)arrayList[0];             // Unboxing
            string second = (string)arrayList[2];      // Unboxing

            // 4. Multiple data types are possible
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(10);
            arrayList1.Add(20);
            arrayList1.Add("Hello");
            arrayList1.Add(false);

            // 5. Looping
            foreach (object x in arrayList1)
            {
                Console.WriteLine(x);
            }

            // 6. Performance issue example (Boxing & Unboxing)
            ArrayList arrayList1000items = new ArrayList();
            for (int i = 0; i < 1000; i++)
            {
                arrayList1000items.Add(i);  // Each int is boxed
            }

            // Example of accessing a specific item
            object obj = arrayList1000items[10];  // Still needs unboxing if treated as int
        }
    }
}
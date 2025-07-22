using System;

namespace TupleNamespace
{
    class ExampleTuple
    {
        static void Main()
        {
            // Reference type tuple using System.Tuple
            Tuple<int, string, string> data = Tuple.Create(1, "John", "Bangalore");
            Tuple<string> data1 = Tuple.Create("Bangalore");

            Console.WriteLine(data.Item1);   // 1
            Console.WriteLine(data.Item2);   // John
            Console.WriteLine(data1.Item1);  // Bangalore

            // Value type tuple (ValueTuple)
            (int ID, string Name, string Location) student = (1, "John", "Bangalore");

            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Location);

            // Calling method that returns a tuple
            (int ID, string Name, string Location) refEmployee = GetEmployee();

            Console.WriteLine(refEmployee.ID);
            Console.WriteLine(refEmployee.Name);
            Console.WriteLine(refEmployee.Location);

            // Check if empid() returns 1, update to 2 if true
            int eid = GetEmpId();
            if (eid == 1)
            {
                eid = 2;
            }

            // Deconstruct tuple from values
            var (id, name, location) = (eid, "John", "Bangalore");

            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(location);
        }

        // Method returning int
        static int GetID()
        {
            return 1;
        }

        // Method returning a value tuple
        static (int ID, string Name, string Location) GetEmployee()
        {
            int empId = 1;
            string empName = "John";
            string location = "Bangalore";

            return (empId, empName, location);
        }

        
        static int GetEmpId()
        {
            
            return 101;
        }
    }
}
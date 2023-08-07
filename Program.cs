using _7_8_23_Assign_24_XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _7_8_23_Assign_24_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 11,
                FirstName = "Simbu",
                LastName = "M",
                Salary = 41000.00
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("E:\\hd\\7-8-23-Assign 24\\7-8-23-Assign 24\\employee.bin", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
                Console.WriteLine("Created and Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            using (FileStream fs = new FileStream("E:\\hd\\7-8-23-Assign 24\\7-8-23-Assign 24\\employee.bin", FileMode.Open))
            {
                employee = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("De-Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            Console.ReadKey();
        }
    }
}


using System;
using _7_8_23_Assign_24;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _7_8_23_XML
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
                Salary = 50000.00
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("E:\\hd\\7-8-23-XML\\7-8-23-XML\\employee.xml"))
            {
                serializer.Serialize(writer, employee);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {employee.Id}");
                Console.WriteLine($"First Name: {employee.FirstName}, Last Name: {employee.LastName}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }
            using (TextReader reader = new StreamReader("E:\\hd\\7-8-23-XML\\7-8-23-XML\\employee.xml"))
            {
                Employee deserialize = (Employee)serializer.Deserialize(reader);
                Console.WriteLine("De-Serialization");
                Console.WriteLine($"Id: {deserialize.Id}");
                Console.WriteLine($"First Name: {deserialize.FirstName}, Last Name: {deserialize.LastName}");
                Console.WriteLine($"Salary: {deserialize.Salary}");
            }
            Console.ReadKey();
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { EmpID = 101, Name = "Robert", Salary = 30000 };
            FileStream fs = new FileStream("binary.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Serialization Done");

            fs = new FileStream("binary.txt", FileMode.Open, FileAccess.Read);
            Employee anotherEmp = (Employee)bin.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Employee ID : " + anotherEmp.EmpID);
            Console.WriteLine("Employee Name : " + anotherEmp.Name);
            Console.WriteLine("Employee Salary : " + anotherEmp.Salary);

            Console.ReadKey();
        }
    }
}

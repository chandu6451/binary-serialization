using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationDemo
{
    [Serializable]
    public class Employee
    {
        int id;
        public int EmpID { get { return id; } set { id = value; } }

        string name;
        public string Name { get { return name; } set { name = value; } }

        [NonSerialized]
        double sal;
        public double Salary { get { return sal; } set { sal = value; } }
    }
}

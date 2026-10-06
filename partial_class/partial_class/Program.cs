using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeName("Devang");
            employee.EmployeeId(101);
            employee.EmployeeId(30000);
        }
    }
}


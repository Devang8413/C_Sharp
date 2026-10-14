using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLEmployeeManagementLibrary;

namespace EmployeeMGM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Devang",50000);

            employee.UpdateId();
            employee.DisplayEmployeeDetails();

            Employee employee2 = new Employee("John", 60000);
            employee2.UpdateId();
            employee2.DisplayEmployeeDetails();
        }
    }
}

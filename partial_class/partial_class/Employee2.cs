using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    internal partial class Employee
    {
        public void EmployeeSalary(decimal salary)
        {
            Console.WriteLine("Employee Salary : " + salary);
        }
    }
}
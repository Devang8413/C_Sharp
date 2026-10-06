using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_example
{
    public static class Patient
    {
        public static void PatientName(string name)
        {
            Console.WriteLine($"Name : {name}");
        }
        public static void PatientDescription(string description)
        {
            Console.WriteLine($"Patient Description : {description}");
        }
    }
}

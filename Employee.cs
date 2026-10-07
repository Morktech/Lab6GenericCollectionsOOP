using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6GenericCollectionsOOP
{
    internal class Employee
    {
        int Identification { get; set; }
        string Name { get; set; } = "";
        bool? Gender { get; set; } = null;
        decimal Salary { get; set; } = 0;

        public Employee()
        {

        }
    }
}

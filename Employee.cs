using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6GenericCollectionsOOP
{
    internal class Employee
    {
        // 4 Properties 
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public decimal Salary { get; set; } = 0;

        public Employee(int id, string name, string gender, decimal salary )
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}

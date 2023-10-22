using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class EmployeeList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}";
        }
    }
}

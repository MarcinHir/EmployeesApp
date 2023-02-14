using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
        public DateTime StartingWorkingTime { get; set; }
        public DateTime? EndOfWorkingTime { get; set; }
        public double Salary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6 {
    internal class Instructor : Person, IInstructorService {

        public Department Department { get; set; }
        public bool IsHeadOfDepartment { get; set; }
        public DateTime JoinDate { get; set; }

        public Instructor(string name, DateTime birthDate, decimal salary, DateTime joinDate)
            : base(name, birthDate, salary) {
            JoinDate = joinDate;
        }

        public override decimal CalculateSalary() {
            int experienceYears = DateTime.Now.Year - JoinDate.Year;
            return base.CalculateSalary() + experienceYears * 1000; // Adding bonus based on experience
        }

    }
}

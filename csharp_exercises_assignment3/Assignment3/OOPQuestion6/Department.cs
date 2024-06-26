using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6 {
    internal class Department : IDepartmentService {

        public string DepartmentName { get; set; }
        public Instructor? Head { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public Department(string departmentName, decimal budget, DateTime startDate, DateTime endDate) {
            DepartmentName = departmentName;
            Budget = budget;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}

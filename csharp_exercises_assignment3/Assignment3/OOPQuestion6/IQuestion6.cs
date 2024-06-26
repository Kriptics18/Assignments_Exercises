using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6
{
    internal interface IPersonService {
        int CalculateAge();
        decimal CalculateSalary();
        List<string> GetAddresses();
    }

    internal interface IStudentService : IPersonService {        
        double CalculateGPA();
    }

    internal interface IInstructorService : IPersonService {
        Department Department { get; set; }
        bool IsHeadOfDepartment { get; set; }
    }

    internal interface IDepartmentService {
        Instructor Head { get; set; }
        decimal Budget { get; set; }
        List<Course> Courses { get; set; }
    }

    internal interface ICourseService {
        List<Student> GetEnrolledStudents();
    }
}

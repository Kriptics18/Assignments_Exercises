using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6 {
    internal class Course : ICourseService {

        public string CourseName { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public Course(string courseName) {
            CourseName = courseName;
        }

        public void EnrollStudent(Student student) {
            EnrolledStudents.Add(student);
        }

        public List<Student> GetEnrolledStudents() {
            return EnrolledStudents;
        }

    }
}

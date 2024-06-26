using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6 {
    internal class Student : Person, IStudentService {

        public List<(Course Course, char Grade)> Courses { get; set; } = new List<(Course Course, char Grade)>();

        public Student(string name, DateTime birthDate, decimal salary)
            : base(name, birthDate, salary) {
        }

        public void AddCourse(Course course, char grade) {

            Courses.Add((course, grade));
            course.EnrollStudent(this);

        }

        public double CalculateGPA() {
            if (Courses.Count == 0) {
                return 0;
            }

            double totalPoints = 0;
            foreach (var (course, grade) in Courses) {
                totalPoints += GradeToPoint(grade);
            }
            return totalPoints / Courses.Count;
        }

        private double GradeToPoint(char grade) {
            return grade switch {
                'A' => 4.0,
                'B' => 3.0,
                'C' => 2.0,
                'D' => 1.0,
                'F' => 0.0,
                _ => throw new ArgumentException("Invalid grade"),
            };
        }

        public override decimal CalculateSalary() {
            // No idea how to calculate salary for a student, but maybe part time work, or some scholarship calculation
            
            return base.CalculateSalary();
        }

    }
}

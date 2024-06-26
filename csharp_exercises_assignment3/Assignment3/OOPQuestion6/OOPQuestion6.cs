using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6
{
    internal class OOPQuestion6 {

        static void Main(string[] args) {
            // Create a department
            Department csDepartment = new Department("Computer Science", 500000, new DateTime(2023, 9, 1), new DateTime(2024, 6, 30));

            // Create an instructor
            Instructor instructor = new Instructor("Dr. Smith", new DateTime(1980, 5, 10), 60000, new DateTime(2010, 9, 1)) {
                Department = csDepartment,
                IsHeadOfDepartment = true
            };

            csDepartment.Head = instructor;

            // Create a student
            Student student = new Student("Alice", new DateTime(2000, 3, 15), 0);

            // Create courses
            Course course1 = new Course("Data Structures");
            Course course2 = new Course("Algorithms");

            // Add courses to department
            csDepartment.Courses.Add(course1);
            csDepartment.Courses.Add(course2);


            // Enroll student in courses and assign their obtained grade
            student.AddCourse(course1, 'A');
            student.AddCourse(course2, 'B');

            // Calculate and print student GPA
            Console.WriteLine($"{student.Name}'s GPA: {student.CalculateGPA()}");

            // Calculate and print instructor salary
            Console.WriteLine($"{instructor.Name}'s Salary: {instructor.CalculateSalary()}");

            // Print addresses
            student.Addresses.Add("123 Main St");
            instructor.Addresses.Add("456 College Ave");
            Console.WriteLine($"{student.Name}'s Addresses: {string.Join(", ", student.GetAddresses())}");
            Console.WriteLine($"{instructor.Name}'s Addresses: {string.Join(", ", instructor.GetAddresses())}");
        }

    }
}

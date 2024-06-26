using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    internal class OOPQuestion2345 {


        abstract class Person {
            // Question 3 Properties common to all person types (Encapsulation)
            public string? Name { get; set; }
            public int Age { get; set; }

            // Question 2 Abstract Method (Abstraction)
            public abstract void DisplayRole();

            // Question 2 Abstract Method (Abstraction)
            public abstract void PerformDuty();

            // Question 4 Concrete Method will be inherited by all derived classes (Inheritance)
            public void DisplayInfo() {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
            }
        }

        // Question 4 Concrete Class for Student (Inheritance)
        class Student : Person {

            // Question 3 Properties specific to student (Encapsulation)
            public string StudentID { get; set; }

            // Constructor
            public Student(string name, int age, string studentID) {
                Name = name;
                Age = age;
                StudentID = studentID;
            }

            // Question 5 Overriding Abstract Method (Polymorphism)
            public override void DisplayRole() {
                Console.WriteLine($"{Name} is a student.");
            }

            // Question 5 Overriding Abstract Method (Polymorphism)
            public override void PerformDuty() {
                Console.WriteLine($"{Name} is studying for exams.");
            }
        }

        // Question 4 Concrete Class for Instructor (Inheritance)
        class Instructor : Person {

            // Question 3 Properties specific to instructor (Encapsulation)
            public string EmployeeID { get; set; }

            // Constructor
            public Instructor(string name, int age, string employeeID) {
                Name = name;
                Age = age;
                EmployeeID = employeeID;
            }

            // Question 5 Overriding Abstract Method (Polymorphism)
            public override void DisplayRole() {
                Console.WriteLine($"{Name} is an instructor.");
            }

            // Question 5 Overriding Abstract Method (Polymorphism)
            public override void PerformDuty() {
                Console.WriteLine($"{Name} is teaching a class.");
            }
        }

        static void Main(string[] args) {

            Student student = new Student("Alice", 20, "S12345");
            Instructor instructor = new Instructor("Bob", 45, "E67890");

            //Demonstrate Encapsulation
            student.Name = "AliceGlass";
            student.Age = 21;
            student.StudentID = "S12346";

            instructor.Name = "BobSmith";
            instructor.Age = 46;
            instructor.EmployeeID = "E67891";

            // Demonstrate Inheritance
            student.DisplayInfo();
            instructor.DisplayInfo();

            // Demonstrate Abstraction and Polymorphism
            Person person1 = student;
            Person person2 = instructor;

            person1.DisplayRole();
            person1.PerformDuty();

            person2.DisplayRole();
            person2.PerformDuty();
        }

    }
}

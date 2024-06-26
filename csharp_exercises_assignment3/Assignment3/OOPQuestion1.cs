using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    internal class OOPQuestion1 {

        // Abstract Class (Abstraction)
        abstract class Animal {
            // Abstract Method (Abstraction)
            public abstract void MakeSound();

            //Concrete Method
            public void Sleep() {
                Console.WriteLine("Sleeping...");
            }
        }


    // Derived Class (Inheritance)
    class Cat : Animal {

            // Encapsulation
            private string name;

            // Encapsulation
            public string Name {
                get { return name; }
                set { name = value; }
            }

            public Cat(string name) {
                this.name = name;
            }

            // Overriding Abstract Method (Polymorphism)
            public override void MakeSound() {
                Console.WriteLine("Meow");
            }
        }


        static void Main(string[] args) {
            // Create instance of Cat
            Cat cat = new Cat("Whiskers");

            // Demonstrate Encapsulation
            cat.Name = "Kitty";

            Console.WriteLine($"Cat's name: {cat.Name}");

            // Demonstrate Polymorphism
            Animal myCat = cat;

            myCat.MakeSound(); // Outputs: Meow

            // Demonstrate Inheritance
            myCat.Sleep(); // Outputs: Sleeping...
        }

    }
}

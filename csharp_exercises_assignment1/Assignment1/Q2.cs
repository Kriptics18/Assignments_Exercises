using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    internal class Q2 {
        public String answers() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Value types hold the actual data directly and are stored on the stack. Examples include int, float, and structs. When a value type is assigned to another, a copy of the value is made, so changes to one do not affect the other.\n");
            sb.Append("Reference types hold a reference to the data, which is stored on the heap. Examples include string, arrays, and classes. Assigning one reference type variable to another copies the reference, so both variables point to the same data, and changes to one variable affect the other.\n");
            sb.Append("Value types are faster to access and store, but reference types are more flexible and can be used to create complex data structures.\n");
            sb.Append("The origin of these traces back to using pointers in languages like C where you could directly access memory locations. In C#, value types are stored on the stack, and reference types are stored on the heap.\n");

            sb.Append("Boxing is the process of converting a value type to a reference type by wrapping the value inside an object or an interface type, allowing value types to be treated as objects. For example, \n\tint number = 123; \n\tobject boxed = number; \nconverts the int to an object.\n");
            sb.Append("Unboxing is the reverse process, converting a reference type back to a value type. For example, \n\tint unboxed = (int)boxed; \nconverts the object back to an int.\n");
            return sb.ToString();
        }
    }
}

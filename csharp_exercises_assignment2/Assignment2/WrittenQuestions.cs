using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2 {
    internal class WrittenQuestions {
        public String getAnswers() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("String is immutable, meaning that once a string is created, it cannot be changed. StringBuilder is mutable, meaning that it can be changed. StringBuilder is more efficient when you need to make a lot of changes to a string, but if security and immutability is necessary, for example with passwords, always use strings.\n");
               
            sb.AppendLine("The base class for all arrays in C# is System.Array.\n");
               
            sb.AppendLine("You can sort an array in C# using the Array.Sort() method. This method sorts the elements in an array in ascending order by default.\n");
               
            sb.AppendLine("The Length property of an array object can be used to get the total number of elements in an array. The Length property can be accessed as follows: int length = arr.Length;\n");
               
            sb.AppendLine("No, you cannot store multiple data types in a System.Array. The elements in an array must be of the same data type.\n");
               
            sb.AppendLine("The System.Array.CopyTo() method copies the elements of an array to another array. The System.Array.Clone() method creates a shallow copy of the array. This means that the elements of the new array are references to the same objects as the elements of the original array.\n");

            return sb.ToString();
        }
    }
}

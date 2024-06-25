using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuestion1 {
    internal class ReverseStringWithArray {

        public static string ReverseString(string input) {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}

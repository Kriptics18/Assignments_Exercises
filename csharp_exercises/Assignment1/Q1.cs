using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Q1
    {
        public String answers() {
            StringBuilder sb = new StringBuilder();
            sb.Append("a. Person's telephone numbers should be either long ints if the ten digits are enforced, or strings since people have a tendency to use dashes when writing out their numbers eg 123-456-7890\n");
            sb.Append("b. Person's height can either be stored as an int for centimetres or inches, or as string or double to account for ft and inches\n");
            sb.Append("c. Person's age should be stored as int (years / months) or string with enforced rules around notation (5y2m) or again double with 5.2\n");
            sb.Append("d. Person's gender, since it involves a preset list of options, is best stored in an enum\n");
            sb.Append("e. Person's salary should be stored as a double to enable precise calculations\n");
            sb.Append("f. ISBN should be stored either as a long int or as a string to allow dashes\n");
            sb.Append("g. Book's price should be stored as a double to enable precise calculations\n");
            sb.Append("h. Book's weight should be stored as a double\n");
            sb.Append("i. Country's population shuold be stored as a long int\n");
            sb.Append("j. Number of stars should be stored as ulong - unsigned long int\n");
            sb.Append("k. Numebr of employees of a company, esp if limited to < 30,000, should be stored in an int\n");

            return sb.ToString();
        }
    }
}

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
            sb.AppendLine("a. Person's telephone numbers should be long int.\n");
            sb.AppendLine("b. Person's height can either be stored as an int for centimetres or inches, or as double to account for ft and inches eg. 6.2\n");
            sb.AppendLine("c. Person's age should be stored as int (years / months) or  double with 5.2\n");
            sb.AppendLine("d. Person's gender, since it involves a preset list of options, is best stored in an enum. However, if limited to storing as numbers, the ebst way to do this would be to use const integers with 0, 1, 2 representing the options.\n");
            sb.AppendLine("e. Person's salary should be stored as a double to enable precise calculations\n");
            sb.AppendLine("f. ISBN should be stored as a long int\n");
            sb.AppendLine("g. Book's price should be stored as a double to enable precise calculations\n");
            sb.AppendLine("h. Book's weight should be stored as a double\n");
            sb.AppendLine("i. Country's population shuold be stored as a long int\n");
            sb.AppendLine("j. Number of stars should be stored as ulong - unsigned long int\n");
            sb.AppendLine("k. Number of employees of a company, esp if limited to < 30,000, should be stored in an int\n");

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WriitenQuestionsPart2 {
    internal class Answers {
        public String getAnswers() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DivideByZeroException when we divide an integer by 0\n");
            sb.AppendLine("Infinity when we divide a double by 0\n");
            sb.AppendLine("When we overflow an int variable, it wraps around to the other side because under the hood int works as a binary value (as does everything in a computer) which emans it starts treating it as twos complement and gives the maximum value of the other sign\n");
            sb.AppendLine("++y is a prefix unary operator implying that a value of 1 is added to y before it is used for anything. y++ is a postfix unary operator which means that the value of y will eb used as is in the statement but will be incremented by 1 after the current value has been used.\n");
            sb.AppendLine("Break instantly breaks the loop and control goes to the next line after the loop block. Continue skips all the code that has not yet been run in the current iteration of the loop which is the code after the continue statement. A return is not actually about the loop but about the function in which the loop is running - it does not just quit the loop but quits the function as well and returns the value as was needed\n");
            sb.AppendLine("The three parts of a for statement are the loop control variable initialization, then the loop break condition, then the update (usually an increment or decrement). None of the parts are necessary, we can get an infinite loop by for example doing a for( ; ; ) {}.\n");
            sb.AppendLine("The difference between = and == is that = is an assignment operator and its job is to suimply calculate rhs and then store that value either directly or by reference to the identifier in LHS. == is a conditional operator which can be thought of as a fuinction that takes two arguments - LHS and RHS, checks whether they are equal, and returns true or false as required.\n");
            sb.AppendLine("The statement for(;true;){} will compile into an infinite loop since similar to the earlier example, not giving a condition is the same as setting it to true every time and therefore this will also be a valid infinite loop.\n");
            sb.AppendLine("The _ in a switch is similar to the default case in Java or other OOP languages, where it is a catch all where if the option provided to the switch was not in one of the pre defined paths, then everything not covered pre-defined gets caught by the _ case.\n");
            sb.AppendLine("The interface IEnumerable must be implemented by any object that needs to be enumerated over using something like a foreach.\n");
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    internal class CodingQuestion2_Fibbonacci {

        public int Fibbonacci(int n = 1) {
            if (n <= 0) {
                return 0;
            }
            if (n == 1) {
                return 1;
            }
            return Fibbonacci(n - 1) + Fibbonacci(n - 2);
        }

        static void Main(string[] args) {
            CodingQuestion2_Fibbonacci fib = new CodingQuestion2_Fibbonacci();
            Console.WriteLine(fib.Fibbonacci(3));
            Console.WriteLine(fib.Fibbonacci(8));
        }

    }
}

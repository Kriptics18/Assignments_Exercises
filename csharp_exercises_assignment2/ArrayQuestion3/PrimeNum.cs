using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQuestion3 {
    internal class PrimeNum {

        public static int[] FindPrimesInRange(int startNum, int endNum) {
            List<int> primes = new List<int>();

            for (int i = startNum; i <= endNum; i++) {
                if (IsPrime(i)) {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        //using Eratosthenes
        private static bool IsPrime(int number) {
            if (number <= 1) {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) {
                    return false;
                }
            }

            return true;
        }

    }
}

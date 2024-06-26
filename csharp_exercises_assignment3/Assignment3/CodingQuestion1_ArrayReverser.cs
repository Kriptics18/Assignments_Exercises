using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3 {
    internal class CodingQuestion1_ArrayReverser {

        static void Main(string[] args) {

            int[] arr = GenerateNumbers(20);

            PrintNumbers(arr);

            ReverseArray(arr);

            PrintNumbers(arr);
        }

        private static void ReverseArray(int[] arr) {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < arr.Length; i++) {
                stack.Push(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = stack.Pop();
            }

        }

        private static void PrintNumbers(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private static int[] GenerateNumbers(int size = 10) {
            
            int[] arr = new int[size];

            for (int i = 0; i < size; i++) {
                //add a random number between 1 and 1000
                arr[i] = new Random().Next(1, 1000);
            }

            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion7 {
    internal class Ball {

        private int size;
        private Color color;
        private int throwCount;

        // Constructor
        public Ball(int size, Color color) {

            if (size <= 0) {
                throw new ArgumentException("Size must be greater than 0");
            }

            this.size = size;
            this.color = color;
            this.throwCount = 0;
        }

        // Method to pop the ball
        public void Pop() {
            size = -1;
        }

        // Method to throw the ball
        public void Throw() {
            if (size > 0) {
                throwCount++;
            } else {
                Console.WriteLine("The ball has been popped and cannot be thrown.");
            }
        }

        // Method to get the number of times the ball has been thrown
        public int GetThrowCount() {
            return throwCount;
        }

        // Get and set methods for size
        public int Size {
            get { return size; }
            set { size = value; }
        }

        // Get and set methods for color
        public Color Color {
            get { return color; }
            set { color = value; }
        }

    }
}

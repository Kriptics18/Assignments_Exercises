using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion7 {
    internal class Color {

        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Constructor with red, green, blue, and alpha values
        public Color(int red, int green, int blue, int alpha) {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        // Constructor with red, green, and blue values, with default alpha value of 255
        public Color(int red, int green, int blue)
            : this(red, green, blue, 255) {
        }

        // Getters and setters for red, green, blue, and alpha values
        public int Red {
            get { return red; }
            set { red = value; }
        }

        public int Green {
            get { return green; }
            set { green = value; }
        }

        public int Blue {
            get { return blue; }
            set { blue = value; }
        }

        public int Alpha {
            get { return alpha; }
            set { alpha = value; }
        }

        // Method to get the grayscale value
        public int GetGrayScale() {
            return (red + green + blue) / 3;
        }

    }
}

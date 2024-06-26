using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion7 {
    internal class OOPQuestion7 {

        static void Main(string[] args) {

            // Create a few Color instances
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0);
            Color semiTransparentBlue = new Color(0, 0, 255, 200);

            // Create a few Ball instances
            Ball ball1 = new Ball(10, red);
            Ball ball2 = new Ball(20, green);
            Ball ball3 = new Ball(15, semiTransparentBlue);

            // Throw the balls around
            ball1.Throw();
            ball1.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Throw();
            ball3.Throw();

            // Pop a few balls
            ball1.Pop();
            ball3.Pop();

            // Try to throw the popped balls
            ball1.Throw();
            ball3.Throw();

            // Print out the number of times each ball has been thrown
            Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");
            Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");
            Console.WriteLine($"Ball 3 has been thrown {ball3.GetThrowCount()} times.");

            // Print grayscale values
            Console.WriteLine($"Grayscale of red: {red.GetGrayScale()}");
            Console.WriteLine($"Grayscale of green: {green.GetGrayScale()}");
            Console.WriteLine($"Grayscale of semiTransparentBlue: {semiTransparentBlue.GetGrayScale()}");
        }

    }
}

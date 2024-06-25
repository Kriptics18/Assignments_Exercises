/*Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3).
*/

int guess;

while(true) {
    try {
        guess = int.Parse(Console.ReadLine());
    } catch (FormatException) {
        Console.WriteLine("invalid guess");
        continue;
    }
    if (guess < 1 || guess > 3) {
        Console.WriteLine("Your guess is outside the valid range of numbers.");
    } else {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);
        if (guess < randomNumber) {
            Console.WriteLine("Your guess is too low.");
        } else if (guess > randomNumber) {
            Console.WriteLine("Your guess is too high.");
        } else {
            Console.WriteLine("Congratulations! You guessed the correct number.");
            break;
        }
    }
}
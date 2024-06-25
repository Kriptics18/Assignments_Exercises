int n;

Console.WriteLine("Enter the number of lines for the pyramid:");

try {
    n = int.Parse(Console.ReadLine());
} catch (FormatException) {
    Console.WriteLine("Please enter a valid number.");
    return;
}

for (int i = 1; i <= n; i++) {

    for (int j = 0; j < n - i; j++) {
        Console.Write(" ");
    }

    for (int k = 0; k < (2 * i - 1); k++) {
        Console.Write("*");
    }

    Console.WriteLine();
}
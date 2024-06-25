int i, j;

for (i = 1; i <= 4; i++) {
    for (j = 0; j <= 24; j += i) {
        Console.Write(j);
        Console.Write(", ");
    }

    Console.WriteLine();
}
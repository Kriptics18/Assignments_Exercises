//Enter the numbers as a list of whitespace separated integers

Console.WriteLine("Enter the numbers as a list of whitespace separated integers");
String[] inputs = Console.ReadLine()!.Split();
int[] array = Array.ConvertAll(inputs, int.Parse);

Console.WriteLine("Enter the value of k");
int k = int.Parse(Console.ReadLine()!);

int n = array.Length;
int[] sum = new int[n];

for (int r = 1; r <= k; r++) {
    for (int i = 0; i < n; i++) {
        int newPos = (i + r) % n;
        sum[newPos] += array[i];
    }
}

Console.WriteLine(string.Join(" ", sum));
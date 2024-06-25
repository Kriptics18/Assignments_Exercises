Console.WriteLine("Enter the numbers as a list of whitespace separated integers");
String[] inputs = Console.ReadLine()!.Split();
int[] array = Array.ConvertAll(inputs, int.Parse);

if (array.Length == 0) {
    Console.WriteLine("");
    return;
}

int maxLength = 1;
int currentLength = 1;
int maxStart = 0;
int currentStart = 0;

for (int i = 1; i < array.Length; i++) {
    if (array[i] == array[i - 1]) {
        currentLength++;
    } else {
        if (currentLength > maxLength) {
            maxLength = currentLength;
            maxStart = currentStart;
        }

        currentStart = i;
        currentLength = 1;
    }
}

if (currentLength > maxLength) {
    maxLength = currentLength;
    maxStart = currentStart;
}

for (int i = maxStart; i < maxStart + maxLength; i++) {
    Console.Write(array[i] + " ");
}


Console.WriteLine("Enter the numbers as a list of whitespace separated integers");
String[] inputs = Console.ReadLine()!.Split();
int[] array = Array.ConvertAll(inputs, int.Parse);

if (array.Length == 0) {
    Console.WriteLine("");
    return;
}

// using System.Collections.Generic;
Dictionary<int, int> frequency = new Dictionary<int, int>();

foreach (int number in array) {
    if (frequency.ContainsKey(number)) {
        frequency[number]++;
    } else {
        frequency[number] = 1;
    }
}


int mostFrequentNumber = -9999;
int maxFrequency = -1;

foreach (KeyValuePair<int, int> pair in frequency) {

    if (pair.Value > maxFrequency) {
        mostFrequentNumber = pair.Key;
        maxFrequency = pair.Value;
    }

}

Console.WriteLine($"The number {mostFrequentNumber} is the most frequent, occuring {maxFrequency} times.");
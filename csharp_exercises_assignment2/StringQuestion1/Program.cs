using StringQuestion1;

Console.WriteLine("Enter a string to reverse: ");
string input = Console.ReadLine()!;

String rev1 = ReverseStringWithArray.ReverseString(input);

Console.WriteLine($"String reversed by char array: {rev1}");

//reversing by printing the other way round
Console.Write("String reversed by printing in reverse: ");
for (int i = input.Length - 1; i >= 0; i--) {
    Console.Write(input[i]);
}
Console.WriteLine();
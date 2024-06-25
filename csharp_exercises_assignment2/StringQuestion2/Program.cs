using System.Text.RegularExpressions;
using System.Text;

string input = Console.ReadLine()!;


string pattern = @"([ .,;=()&\[\]""'\\/!?]+)";


string[] parts = Regex.Split(input, pattern);


List<String> result = new List<string>();
List<string> words = new List<string>();


foreach (string part in parts) {
    if (!Regex.IsMatch(part, pattern)) {
        words.Add(part);
    }
}

words.Reverse();

int wordIndex = 1;
result.Add(words[0]);

foreach (string part in parts) {
    if (Regex.IsMatch(part, pattern)) {
        
        result.Add(part);
    } else {
        if (wordIndex < words.Count) {
            result.Add(words[wordIndex]);
            wordIndex++;
        }
    }
}

foreach (String Res in result) {
    Console.Write(Res);
}
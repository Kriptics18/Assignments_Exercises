using System.Text.RegularExpressions;

Console.WriteLine("Enter a string:");
string input = Console.ReadLine()!;


string pattern = @"\b\w+\b";

//using a set to preserve unique values
HashSet<string> palindromes = new HashSet<string>();

// Check each word and add to the set if it's a palindrome
foreach (Match match in Regex.Matches(input, pattern)) {
    string word = match.Value;
    if (IsPalindrome(word)) {
        palindromes.Add(word);
    }
}

List<string> sortedPalindromes = palindromes.ToList();


sortedPalindromes.Sort((x, y) => IgnoreCaseCompare(x, y));

// Print the sorted palindromes
Console.WriteLine(string.Join(", ", sortedPalindromes));


bool IsPalindrome(string word) {
    int left = 0;
    int right = word.Length - 1;
    while (left < right) {
        if (char.ToLower(word[left]) != char.ToLower(word[right])) {
            return false;
        }
        left++;
        right--;
    }
    return true;
}

static int IgnoreCaseCompare(string x, string y) {
    string lowerX = x.ToLower();
    string lowerY = y.ToLower();
    return string.Compare(lowerX, lowerY);
}
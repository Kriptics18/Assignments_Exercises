// create an array of strings of dynamic size

List<string> itemList = new List<string>();

while (true) {

    Console.WriteLine();
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine() ?? "";

    if (input.StartsWith("+ ")) {

        string itemToAdd = input.Substring(2);
        itemList.Add(itemToAdd);
        Console.WriteLine($"Added: {itemToAdd}");

    } else if (input.StartsWith("- ")) {

        string itemToRemove = input.Substring(2);
        if (itemList.Remove(itemToRemove)) {
            Console.WriteLine($"Removed: {itemToRemove}");
        } else {
            Console.WriteLine($"Item not found: {itemToRemove}");
        }
    } else if (input == "--") {

        itemList.Clear();
        Console.WriteLine("List cleared.");

    } else {
        Console.WriteLine("Invalid command.");
    }

    Console.WriteLine("Current list:");
    if (itemList.Count == 0) {
        Console.WriteLine("List is empty.");
    } else {
        foreach (string item in itemList) {
            Console.WriteLine(item);
        }
    }
}
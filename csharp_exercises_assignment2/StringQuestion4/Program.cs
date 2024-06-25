
Console.WriteLine("Enter a URL: ");
string input = Console.ReadLine()!;


string protocol = "";
string server = "";
string resource = "";


int currentIndex = 0;


int protocolEnd = input.IndexOf("://");
//if the protocol is found
if (protocolEnd != -1) {
    protocol = input.Substring(0, protocolEnd);
    currentIndex = protocolEnd + 3;
}


int serverEnd = input.IndexOf('/', currentIndex);

//if resource exists
if (serverEnd != -1) {
    server = input.Substring(currentIndex, serverEnd - currentIndex);
    currentIndex = serverEnd + 1;
} else {
    server = input.Substring(currentIndex);
    currentIndex = input.Length;
}


if (currentIndex < input.Length) {
    resource = input.Substring(currentIndex);
}


Console.WriteLine($"[protocol] = \"{protocol}\"");
Console.WriteLine($"[server] = \"{server}\"");
Console.WriteLine($"[resource] = \"{resource}\"");
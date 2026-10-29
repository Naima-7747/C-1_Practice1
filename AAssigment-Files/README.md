## C# File

## Explain the functions

1. Read File
   Reads text from a file.
   string[] lines = File.ReadAllLines("index.txt");
   disply.Items.AddRange(lines);

2. Delete Item
   Removes a specific item from the file.
   var lines = File.ReadAllLines("index.txt")
   .Where(x => x != "Java");
   File.WriteAllLines("index.txt", lines);

3. Delete File
   Deletes the whole file.
   File.Delete("index.txt");

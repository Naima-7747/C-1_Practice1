Chapter 4: Loops, Files, and Random Numbers

# Topics Covered

1. While Loop – Repeats statements while a condition is true.
2. Increment (++) and Decrement (--) – Increase or decrease a variable by 1.
3. For Loop – Repeats code using initialization, condition, and update.
4. Do-While Loop – Executes code at least once before checking the condition.
5. File Handling – Creating, writing, reading, and closing files.
6. OpenFileDialog – Opens files using a Windows dialog box.
7. SaveFileDialog – Saves files using a Windows dialog box.
8. Random Numbers – Generates random numbers using the Random class.
9. Load Event – Executes code when a form loads.

# C# Code Examples

1. While Loop

int count = 0;

while (count < 5)
{
MessageBox.Show(count.ToString());
count++;
}

2. For Loop

for (int i = 1; i <= 5; i++)
{
MessageBox.Show(i.ToString());
}

3. Do-While Loop

int number = 1;

do
{
MessageBox.Show(number.ToString());
}
while (number < 0);

4. Write to File

StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Computer Science");
outputFile.Close();

5. Read from File

StreamReader inputFile;
inputFile = File.OpenText("courses.txt");

while (!inputFile.EndOfStream)
{
string line = inputFile.ReadLine();
MessageBox.Show(line);
}

inputFile.Close();

6. Random Numbers

Random rand = new Random();

int number = rand.Next(100);
MessageBox.Show(number.ToString());

---

# Chapter: 4 – Loops, Files, and Random Numbers

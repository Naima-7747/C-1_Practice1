# Chapter 4: Loops, Files, and Random Numbers

# 4.1 The while Loop

What is a while loop?
A while loop causes a statement or a group of statements to repeat as long as a Boolean expression is true.

Its basic logic is:
While a Boolean expression is true, perform a task.

A while loop has two parts:

1. Boolean expression: a condition that is tested as either true or false.
2. Loop body: the statement or statements repeated while the condition remains true.
   General syntax
   while (BooleanExpression)
   {
   statements;
   }

- The first line is called the while clause.
- Statements inside the curly braces { } are called the body of the loop.
- When the loop executes, the Boolean expression is tested.
- If the expression is true, the statements inside the body execute.
- Each time the body executes, the loop performs an iteration.
- A counter variable is a variable used to track how many times a loop runs.
  Example: Loop runs five times
  int count = 0;

while (count < 5)
{
MessageBox.Show("Hello");
count = count + 1;
}

A while loop is a pretest loop because it tests its condition before performing an iteration.

This means the condition may be false before the loop starts. If it is false at the beginning, the loop body will not execute at all.

Example:
int count = 5;

while (count < 5)
{
MessageBox.Show("Hello");
count = count + 1;
}
Result: The message box will not appear. The initial value is 5, and 5 < 5 is false.
Infinite loops
An infinite loop is a loop that continues repeating until the program is interrupted.

A common cause is forgetting to write code that changes the condition so it eventually becomes false.

Example:
int count = 0;

while (count < 5)
{
MessageBox.Show("Hello");
}
Why is this an infinite loop?

- count starts at 0.
- count < 5 remains true.
- The value of count is never increased.
- Therefore, the condition never becomes false and the loop does not stop normally.

  4.2 The ++ and -- Operators
  Increment and decrement

- To increment a variable means to increase its value.
- To decrement a variable means to decrease its value.
  C# provides the ++ and -- operators for these operations.
  Incrementing by one
  All three statements below increase count by one:
  count++;
  count += 1;
  count = count + 1;
  Decrementing by one
  All three statements below decrease count by one:
  count--;
  count -= 1;
  count = count - 1;
  Postfix mode versus prefix mode
  The ++ and -- operators can be placed before or after their operands.

Postfix mode: place the operator after the variable.
count++;
Prefix mode: place the operator before the variable.
++count;
The difference matters when the expression's value is being used:

- Postfix: use the old value first, then change the variable.
- Prefix: change the variable first, then use the new value.
  The same prefix/postfix distinction applies to decrement:
  count--; // Postfix decrement
  --count; // Prefix decrement
  The chapter includes slides illustrating postfix and prefix

  4.3 The for Loop
  What is a for loop?
  The for loop is designed especially for situations where a counter variable controls the number of iterations.

A for loop specifies three actions:

1. Initialization: a one-time expression that defines the counter's initial value.
2. Test: a Boolean expression. If it is true, the loop body executes.
3. Update: increases or decreases the counter variable.
   General syntax
   for (InitializationExpression; TestExpression; UpdateExpression)
   {
   statements;
   }
   A for loop is a pretest loop: its condition is tested before the loop body executes.
   Example: Count from 0 to 4
   The counter can be declared before the loop:
   int count;

for (count = 0; count < 5; count++)
{
MessageBox.Show("Hello");
}
Or it can be declared in the initialization expression:
for (int count = 0; count < 5; count++)
{
MessageBox.Show("Hello");
}

Count by tens:
// Increment by 10.
for (int count = 0; count <= 100; count += 10)
{
MessageBox.Show(count.ToString());
}
This counts 0, 10, 20, ... 100.

Count backwards:
// Counting backward.
for (int count = 10; count >= 0; count--)
{
MessageBox.Show(count.ToString());
}
This counts from 10 down to 0.
Practice reminder

4.4 The do-while Loop
What is a do-while loop?
The do-while loop is a posttest loop. It performs an iteration before testing its Boolean expression.

This means its body always executes at least once, even if the condition is false at the beginning.
General syntax
do
{
statements;
} while (BooleanExpression);
Important: The while condition at the end must be followed by a semicolon.
Example: do-while with a false condition
int number = 1;

do
{
MessageBox.Show(number.ToString());
} while (number < 0);
Will you see the message box? Yes.

- The body executes first and displays 1.
- After that, number < 0 is tested.
- The condition is false, so the loop stops.
- The body still executed once.
  Compare with while
  int number = 1;

while (number < 0)
{
MessageBox.Show(number.ToString());
}
Will you see the message box? No.

- A while loop tests the condition first.
- 1 < 0 is false.
- Therefore, the body never executes.
  Main difference
- while: tests first; may execute zero times.
- do-while: executes first and tests afterward; executes at least once.
  5.5 Using Files for Data Storage
  Why use files?
  When a program needs to save data for later use, it writes the data to a file.
  Three steps for working with a file
  There are always three basic steps:

1. Open the file: create a connection between the file and the program.
2. Process the file: read data from it or write data to it.
3. Close the file: disconnect the file from the program.
   Types of files
   There are two general types:

4. Text file

- Contains data encoded as text using a scheme such as Unicode.
- Its contents can be viewed with a text editor.

2. Binary file

- Contains data that has not been converted to text.
- Its contents cannot be viewed as ordinary text using a text editor.
  Chapter scope: This chapter works with text files.
  File objects and .NET classes
  A file object is an object associated with a specific file. It provides a way for a program to work with that file.

.NET provides two classes used in this chapter:
Class Purpose
StreamWriter Writing data to a text file
StreamReader Reading data from a text file

Writing data to a file
The basic steps are:

1. Create a StreamWriter object.
2. Use a File method to open the file.
3. Use Write or WriteLine to write data.
4. Close the connection.
   First declare the object:
   StreamWriter outputFile;
   The chapter introduces these File methods:
   File.CreateText
   File.AppendText
   Example: Create a file and write lines
   StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();
Explanation:

- StreamWriter outputFile; declares a StreamWriter variable.
- File.CreateText("courses.txt") creates/opens the text file for writing.
- Each WriteLine writes text and then adds a newline character.
- Close() closes the file connection.
  Write versus WriteLine
  Method What it does
  Write() Writes an item to the file without adding a newline character.
  WriteLine() Writes an item and then adds a newline character, marking the end of that line.

CreateText versus AppendText
File.CreateText()

- Creates a text file with the name specified in its argument.
- If the file already exists, its existing contents are erased.
- Creates a StreamWriter object in memory associated with the file.
- Returns a reference to that StreamWriter object.
  Example:
  StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");
File.AppendText()

Use this when you want to add data without erasing the existing contents of a file.

Example:
StreamWriter outputFile;

outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");

outputFile.Close();
Specifying the location of an output file
You can specify a path as well as a filename when opening an output file.

The chapter shows using the @ character before a path string so backslashes can be written without escaping each one:
StreamWriter outputFile =
File.AppendText(@"C:\Data\Names.txt");
It also shows a path written with doubled backslashes:
outputFile =
File.CreateText("D:\\C#\\Last_Update_C#\\CA232\\EndBalanceCalc\\bin\\Debug\\listocurse1.doc");
Reading data from a file
The basic steps are:

1. Create a StreamReader object.
2. Use File.OpenText() to open the file.
3. Read data using a reading method.
4. Close the connection.
   Declare the reader:
   StreamReader inputFile;
   Open a text file:
   inputFile = File.OpenText("students.txt");
   StreamReader and file-reading methods
   Method Purpose
   ReadLine() Reads a line of characters from the current stream and returns the data as a string.
   Read() Reads the next character or next set of characters from the input stream.
   ReadToEnd() Reads the remaining contents of the stream to the end.
   File.ReadAllText() Reads the contents of a file as text.

After reading, close the connection:
inputFile.Close();
Reading a file with a loop
A StreamReader object has a Boolean property called EndOfStream. It indicates whether the end of the file has been reached.

You can use it in a loop to keep reading until the end of the file.

Long form:
while (inputFile.EndOfStream == false)
{
// Read and process a line here.
}
Short form:
while (!inputFile.EndOfStream)
{
// Read and process a line here.
}
The ! operator means NOT. Therefore, !inputFile.EndOfStream means the loop continues while the end of the file has not been reached.

A typical line-reading pattern is:
while (!inputFile.EndOfStream)
{
string line = inputFile.ReadLine();
// Process the line.
}

4.6 The OpenFileDialog and SaveFileDialog Controls
Purpose
The OpenFileDialog and SaveFileDialog controls allow an application to display standard Windows dialog boxes for opening and saving files.

Unlike controls such as Label, Button, and TextBox, these are invisible controls. They do not appear directly on the form at runtime like ordinary visible controls.

- OpenFileDialog displays a standard Windows Open dialog box.
- SaveFileDialog displays a standard Windows Save As dialog box.
  Where the controls appear in the Designer
  When an OpenFileDialog control is added to a Windows Form, it does not appear on the form itself. It appears in the component tray, the area at the bottom of the Designer.
  Displaying an Open dialog box
  Call the control's ShowDialog() method:
  private void openButton_Click(object sender, EventArgs e)
  {
  openFileDialog.ShowDialog();
  }
  Detecting the user's selection
  The ShowDialog() method returns a DialogResult value indicating which button the user clicked to close the dialog.
- DialogResult.OK: the user clicked Open.
- DialogResult.Cancel: the user clicked Cancel.
  Example:
  DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
// The user selected Open.
}
else if (result == DialogResult.Cancel)
{
// The user selected Cancel.
}
Filename property
When the user selects a file in the Open dialog box, the selected file's path and filename are stored in the control's Filename property (commonly written as FileName in C# Windows Forms APIs).

The chapter's example opens the selected file like this:
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
inputFile = File.OpenText(openFileDialog.FileName);
}
InitialDirectory property
You can specify the directory that the dialog initially displays by setting InitialDirectory.

Example:
openFileDialog.InitialDirectory = @"C:\Data";
Displaying a Save As dialog box
Call the SaveFileDialog control's ShowDialog() method:
saveFileDialog.ShowDialog();
To detect whether the user selected OK:
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
// The user selected OK.
}
To open the selected file for writing, the chapter shows this pattern:
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
outputFile = File.CreateText(saveFileDialog.FileName);
}
Remember:

- Use OpenFileDialog when the user needs to choose a file to open.
- Use SaveFileDialog when the user needs to choose where to save a file.
- Check for DialogResult.OK before using the selected filename.
- The selected path and filename are available through the dialog control's FileName property.
  5.7 Random Numbers
  Random class
  .NET provides the Random class to generate random numbers.

Create a Random object:
Random rand = new Random();
Common methods
Two commonly used methods are:
Method Purpose
Next() Generates a random integer.
NextDouble() Generates a random floating-point number from 0.0 to 1.0.

Examples:
int number1 = rand.Next();

double number2 = rand.NextDouble();
Syntax of the Random.Next method
Random.Next() can generate an integer from 0 through 2,147,483,647.

It can also generate a random integer from zero up to (but not including) a specified maximum value.

You can create a Load event handler by double-clicking the form in the Designer.
Empty Load event handler
private void Form1_Load(object sender, EventArgs e)
{

}
Writing code in the Load event
Any code written inside the Load event handler executes when the form is launched.

Example:
private void Form1_Load(object sender, EventArgs e)
{
MessageBox.Show("Prepare to see the form!");
}

# Choosing a loop

- Use while when repetition depends on a condition and the number of repetitions may not be known in advance.
- Use for when a counter is used to control the number of repetitions.
- Use do-while when the statements must execute at least once before the condition is checked.

# Important Code Patterns

1. while loop
   int count = 0;

while (count < 5)
{
MessageBox.Show("Hello");
count++;
} 2. Increment and decrement
count++;
count--; 3. for loop
for (int count = 0; count < 5; count++)
{
MessageBox.Show("Hello");
} 4. do-while loop
int number = 1;

do
{
MessageBox.Show(number.ToString());
} while (number < 0); 5. Write to a text file
StreamWriter outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close(); 6. Append to a text file
StreamWriter outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");

outputFile.Close(); 7. Read a text file line by line
StreamReader inputFile = File.OpenText("students.txt");

while (!inputFile.EndOfStream)
{
string line = inputFile.ReadLine();
// Process the line.
}

inputFile.Close(); 8. Open a file using OpenFileDialog
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
StreamReader inputFile =
File.OpenText(openFileDialog.FileName);
} 9. Save using SaveFileDialog
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
StreamWriter outputFile =
File.CreateText(saveFileDialog.FileName);
} 10. Generate a random number
Random rand = new Random();

int number1 = rand.Next();
double number2 = rand.NextDouble();

int numberFromZeroToNinetyNine = rand.Next(100); 11. Form Load event
private void Form1_Load(object sender, EventArgs e)
{
MessageBox.Show("Prepare to see the form!");
}

# Chapter 1 —Processing Data

# Topics

3.1 Reading Input with TextBox Controls

3.2 A First Look at Variables

3.3 Numeric Data Type and Variables

3.4 Performing Calculations

3.5 Inputting and Outputting Numeric Values

3.6 Formatting Numbers with the ToString Method

3.7 Simple Exception Handling

3.8 Using Named Constants

3.9 Declaring Variables as Fields

3.10 Using the Math Class

3.11 More G U I Details

3.12 Using the Debugger to Locate Logic Errors

# 3.1 Reading Input with TextBox Controls

TextBox Control

A TextBox is a rectangular area that accepts keyboard input from the user.
It is located in the Common Controls group of the Toolbox.
Double-click the TextBox to add it to the form.
The default name is textBox1, textBox2, textBox3, etc.
The Text Property
The Text property stores the user's input.
The Text property accepts only string values.

# 3.2 A First Look at Variables

A variable is a storage location in memory.
A variable name represents that memory location.
In C#, you must declare a variable before using it to store data.

# Syntax

DataType VariableName;

For example:

int age;
int → Data Type
age → Variable Name

Key point:
DataType VariableName; is the basic syntax for declaring a variable.

# Data Types

-A variable must be declared with a proper data type.
-The data type specifies the type of data a variable can hold.
-Many data types in C# are called primitive data types.
-Primitive data types store basic or fundamental types of data.
-Primitive means basic, simple, or built-in.
-In C#, primitive data types are already defined by the language.

# Variable Names

A variable name identifies a variable.
Always choose a meaningful name for variables.

# Basic Naming Rules

1. The first character must be a letter or an underscore (\_).
2. The name cannot contain spaces.
3. Do not use keywords or reserved words as variable names.

# String Variables

- A string is a combination of characters.
- A string variable can hold characters such as:

* Names
* Phone numbers
* Social security numbers

# Assigning a String Value

A string value is placed on the right side of the = operator and surrounded by double quotation marks.

# productDescription = "Jamhuuriya University";

A string variable can be assigned to a Label:

# productLabel = productDescription;

A string variable can also be displayed in a Message Box:

# MessageBox.Show(productDescription);

String Concatenation
Concatenation means appending one string to the end of another string.
In C#, the + operator is used for concatenation.
Concatenation can happen between a string and another data type.

# 3.8 Using Named Constants

A named constant is a name that represents a value that cannot be changed during program execution.

A constant is declared using the const keyword.

# const double INTEREST_RATE = 0.129;

- Writing constant names in uppercase letters is a common convention.
- Uppercase letters are traditional, not required.

# 3.9 Declaring Variables as Fields

- A field is a variable declared at the class level.
- It is declared inside a class but outside any method.
- A field's scope is the entire class.
- A field is created in memory when the object/form is created.

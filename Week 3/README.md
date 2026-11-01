# C# Chapter 3 -- Making Decisions

This chapter explains how C# programs make decisions based on
conditions. It covers decision structures, logical operators, input
validation, and working with RadioButtons, CheckBoxes, Switch
statements, and ListBoxes.

## Topics Covered

1.  Decision Structures and the `if` Statement
2.  The `if-else` Statement
3.  Nested Decision Structures
4.  Logical Operators (`&&`, `||`, `!`)
5.  `bool` Variables and Flags
6.  Comparing Strings
7.  Preventing Conversion Exceptions with `TryParse()`
8.  Input Validation
9.  RadioButtons and CheckBoxes
10. The `switch` Statement
11. Introduction to ListBoxes

## 1. The if Statement

The `if` statement executes code only when a condition is true.

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
```

## 2. The if-else Statement

The `if-else` statement chooses between two blocks of code.

```csharp
int number = 7;

if (number % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}
```

## 3. Nested if Statement

A nested decision structure is an `if` statement inside another `if`
statement.

```csharp
int age = 22;
bool hasID = true;

if (age >= 18)
{
    if (hasID)
    {
        Console.WriteLine("Access allowed");
    }
    else
    {
        Console.WriteLine("ID is required");
    }
}
else
{
    Console.WriteLine("Access denied");
}
```

## 4. Logical Operators

Logical operators combine or reverse conditions.

Operator Meaning Description

---

`&&` AND Both conditions must be true
`||` OR At least one condition must be true
`!` NOT Reverses a Boolean condition

```csharp
int age = 25;
bool hasTicket = true;

if (age >= 18 && hasTicket)
{
    Console.WriteLine("You can enter.");
}
```

## 5. bool Variables and Flags

A `bool` variable stores either `true` or `false`. A flag indicates
whether a condition exists.

```csharp
bool isLoggedIn = true;

if (isLoggedIn)
{
    Console.WriteLine("Welcome!");
}
```

## 6. Comparing Strings

Strings can be compared using `==`, `!=`, or `String.Compare()`.

```csharp
string name = "Ali";

if (name == "Ali")
{
    Console.WriteLine("Names match.");
}
```

## 7. TryParse()

`TryParse()` checks whether text can be converted to a numeric value
without causing a conversion exception.

```csharp
int age;

if (int.TryParse("21", out age))
{
    Console.WriteLine(age);
}
else
{
    Console.WriteLine("Please enter a valid number.");
}
```

## 8. Input Validation

Input validation checks whether entered data is reasonable and within
the required range.

```csharp
int score = 85;

if (score >= 0 && score <= 100)
{
    Console.WriteLine("Valid score");
}
else
{
    Console.WriteLine("Invalid score");
}
```

## 9. RadioButtons and CheckBoxes

- **RadioButton:** allows the user to select one choice from a group.
- **CheckBox:** allows the user to select or deselect an option.
- The `Checked` property tells whether the control is selected.

```csharp
if (radioButton1.Checked)
{
    MessageBox.Show("Option 1 selected");
}

if (checkBox1.Checked)
{
    MessageBox.Show("Checkbox selected");
}
```

## 10. The switch Statement

The `switch` statement selects a block of code based on a matching
value.

```csharp
string day = "Monday";

switch (day)
{
    case "Monday":
        Console.WriteLine("Start of the week");
        break;

    case "Friday":
        Console.WriteLine("Weekend is near");
        break;

    default:
        Console.WriteLine("Another day");
        break;
}
```

## 11. ListBox

A `ListBox` displays a list of items and allows the user to select an
item.

```csharp
// Add items
listBox1.Items.Add("Apple");
listBox1.Items.Add("Banana");

// Read selected item safely
if (listBox1.SelectedIndex != -1)
{
    string selected = listBox1.SelectedItem.ToString();
    MessageBox.Show(selected);
}

// Remove an item
listBox1.Items.Remove("Apple");

// Remove by index
listBox1.Items.RemoveAt(0);

// Clear all items
listBox1.Items.Clear();
```

## Example Screenshots

### Decision Structures

![If and If-Else examples](screenshots/01-decision-structures.png)

### Logical Operators and Validation

![Logical operators and TryParse
examples](screenshots/02-logic-validation.png)

### Windows Forms Controls

![RadioButton, CheckBox, Switch and ListBox
examples](screenshots/03-controls-listbox.png)

## Key Points

- `if` and `if-else` make decisions.
- Nested `if` statements check more than one level of conditions.
- Logical operators combine conditions.
- `TryParse()` helps prevent conversion exceptions.
- Input validation checks whether data is within an acceptable range.
- RadioButtons, CheckBoxes, Switch statements, and ListBoxes help
  build interactive programs.

---

**Language:** C#\
**Chapter:** Making Decisions\

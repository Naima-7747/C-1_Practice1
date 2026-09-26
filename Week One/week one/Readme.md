# Chapter 1 — Introduction to C#

# Topics

1.1 Objects

1.2 The Program Development Process

1.8 Getting Started with Visual Studio

2.1 Getting Started with Forms and Controls

2.2 Creating the G U I for Your First Visual C# Application

2.3 Introduction to C# code

2.4 Writing Code for the Hello World Application

2.5 Label Controls

2.6 Making Sense of IntelliSense

2.7 PictureBox Controls

2.8 Comments, Blank Lines, and Indentation

2.9 Writing the Code to Close an Application’s Form

2.10 Dealing with Syntax Errors

# 1.1 Objects

An object is a program component that contains data and performs operations.

Objects have:

-Properties/Fields > data stored in the object.
-Methods > operations the object can perform.

- Controls
  Objects that are visible in a program GUI are known as Controls

* Commonly used

- Labels
- Buttons
- TextBoxes

# 1.2 The Program Development Process

The program development process is the general process used to create a computer program.

# 1.2 Getting Started with Visual Studio

Visual Studio is a professional integrated development
environment (I D E)

The Visual Studio Environment includes:

Designer Window

Solution Explorer Window

Properties Window

- Auto Hide allows a window to display only as a tab of the
  edges
  - Menu bar provides menus such as File, Edit, View,
    Project, etc.

# 2.1 Getting Started with Forms and Controls

Dotted lines called the bounding box.

# 2.3 Introduction to c sharp Code

- code is primarily organized in three ways:

* Namespace: a container that holds classes

* Class: a container that holds methods

* Method: a group of one or more programming statements that
  perform some operations

# 2.7 PictureBox Controls

A PictureBox control displays a graphic image on a form

Commonly used properties are:

Image: specifies the image that it will display

SizeMode: specifies how the control’s image is to be
displayed

Visible: determines whether the control is visible on
the form at run time

# 2.9 Writing the Code to Close an

Application’s Form

To close an application’s form in code, use the following
statement:

A commonly used practice is to create an Exit button and
manually add the code to it:

this.Close();

Application.Exit;

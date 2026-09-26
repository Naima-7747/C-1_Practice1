# screen shot 1 CREATIN

This code collects date information from four TextBoxes, combines them into one string, and displays the result in a Label when the button is clicked.

Creating variables: Stores the day, month, day of month, and year.
Input: Gets the values from the TextBoxes.
Process: Combines all values into showdata.
Display: Shows showdata in dataOutLabel.
" " → adds spaces between the values.

# screen shot 2 Clear

This code clears all the TextBoxes and the output Label when button2 is clicked.

txtdayofweek.Text = ""; → clears the day.
txtdayofmonth.Clear(); → clears the day of month.
txtmonth.Text = string.Empty; → clears the month.
txtyear.Text = string.Empty; → clears the year.
dataOutLabel.Text = string.Empty; → clears the output Label.

In short: The button resets the form and removes all entered and displayed data.

# screen shot 3 close

This code closes the current form when button3 is clicked.
In short: The button is used to exit/close the application form.

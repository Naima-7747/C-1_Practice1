using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string guestName = txtName.Text.Trim();

            int age = 0;
            int nights = 0;
            int guests = 0;

            bool bookingApproved = true;
            string rejectionReason = "";

            double rate = 0;
            double basicCost = 0;
            double discount = 0;
            double breakfastCost = 0;
            double serviceCharge = 0;
            double seniorDiscount = 0;
            double totalCost = 0;

            string roomType = "";

            // Validate Guest Name
            if (string.IsNullOrWhiteSpace(guestName))
            {
                bookingApproved = false;
                rejectionReason = "Guest name cannot be empty.";
            }

            // Validate Age
            else if (!int.TryParse(txtAge.Text, out age))
            {
                bookingApproved = false;
                rejectionReason = "Please enter a valid age.";
            }
            else if (age < 18 || age > 90)
            {
                bookingApproved = false;
                rejectionReason = "Guest age must be between 18 and 90.";
            }

            // Validate Number of Nights
            else if (!int.TryParse(txtNights.Text, out nights))
            {
                bookingApproved = false;
                rejectionReason = "Please enter a valid number of nights.";
            }
            else if (nights < 1 || nights > 30)
            {
                bookingApproved = false;
                rejectionReason = "Number of nights must be between 1 and 30.";
            }

            // Validate Number of Guests
            else if (!int.TryParse(txtGuests.Text, out guests))
            {
                bookingApproved = false;
                rejectionReason = "Please enter a valid number of guests.";
            }
            else if (guests < 1 || guests > 6)
            {
                bookingApproved = false;
                rejectionReason = "Number of guests must be between 1 and 6.";
            }

            // Determine Room Type and Capacity
            int capacity = 0;

            if (rbStandard.Checked)
            {
                roomType = "Standard";
                capacity = 2;
            }
            else if (rbNormal.Checked)
            {
                roomType = "Deluxe";
                capacity = 4;
            }
            else if (rbHight.Checked)
            {
                roomType = "Suite";
                capacity = 6;
            }
            else
            {
                bookingApproved = false;
                rejectionReason = "Please select a room type.";
            }

            // Check Room Capacity
            if (bookingApproved && guests > capacity)
            {
                bookingApproved = false;
                rejectionReason = "The selected room cannot accommodate this number of guests.";
            }

            // Calculate Booking Cost
            if (bookingApproved)
            {
                // Determine Room Rate using switch
                switch (roomType)
                {
                    case "Standard":
                        rate = 50;
                        break;

                    case "Deluxe":
                        rate = 80;
                        break;

                    case "Suite":
                        rate = 130;
                        break;

                    default:
                        bookingApproved = false;
                        rejectionReason = "Invalid room type.";
                        break;
                }

                if (bookingApproved)
                {
                    // Basic Cost
                    basicCost = rate * nights;

                    // Discount based on number of nights
                    if (nights >= 5 && nights <= 9)
                    {
                        discount = basicCost * 0.05;
                    }
                    else if (nights >= 10)
                    {
                        discount = basicCost * 0.12;
                    }

                    // Breakfast Cost
                    if (chkBreakfast.Checked)
                    {
                        breakfastCost = 10 * guests * nights;
                    }

                    // Service Charge for more than 4 guests
                    if (guests > 4)
                    {
                        serviceCharge = basicCost * 0.05;
                    }

                    // Additional Senior Discount
                    if (age >= 60)
                    {
                        seniorDiscount = basicCost * 0.05;
                    }

                    // Final Total
                    totalCost = basicCost
                                - discount
                                - seniorDiscount
                                + breakfastCost
                                + serviceCharge;

                    // Display Results
                    lstResult.Items.Clear();

                    lstResult.Items.Add("HOTEL ROOM BOOKING");
                    lstResult.Items.Add("------------------------------");
                    lstResult.Items.Add("Guest Name: " + guestName);
                    lstResult.Items.Add("Guest Age: " + age);
                    lstResult.Items.Add("Room Type: " + roomType);
                    lstResult.Items.Add("Number of Nights: " + nights);
                    lstResult.Items.Add("Number of Guests: " + guests);
                    lstResult.Items.Add("Room Rate: $" + rate.ToString("F2"));
                    lstResult.Items.Add("Basic Cost: $" + basicCost.ToString("F2"));
                    lstResult.Items.Add("Night Discount: $" + discount.ToString("F2"));
                    lstResult.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
                    lstResult.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("F2"));
                    lstResult.Items.Add("Service Charge: $" + serviceCharge.ToString("F2"));
                    lstResult.Items.Add("------------------------------");
                    lstResult.Items.Add("TOTAL COST: $" + totalCost.ToString("F2"));
                    lstResult.Items.Add("Booking Approved!");
                }
            }

            // Display Rejection Message
            if (!bookingApproved)
            {
                lstResult.Items.Clear();
                lstResult.Items.Add("BOOKING REJECTED");
                lstResult.Items.Add(rejectionReason);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
          
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rbStandard.Checked = false;
            rbNormal.Checked = false;
            rbHight.Checked = false;

            chkBreakfast.Checked = false;

            lstResult.Items.Clear();

            txtName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
    }
    


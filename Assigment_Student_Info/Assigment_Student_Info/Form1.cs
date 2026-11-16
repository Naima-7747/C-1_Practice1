using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_Student_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsavetofile_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\Eng Naima\Downloads\Students.txt";

            if (txtSid.Text == "" ||
                txtSname.Text == "" ||
                txtDepartment.Text == "" ||
                txtmark.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            decimal mark;

            if (!decimal.TryParse(txtmark.Text, out mark) || mark < 0)
            {
                MessageBox.Show("Mark must be a non-negative number!");
                return;
            }

            string studentType = "";

            if (rbUndergraduate.Checked)
            {
                studentType = "Undergraduate";
            }
            else if (rbPostgaraduate.Checked)
            {
                studentType = "Postgraduate";
            }
            else
            {
                MessageBox.Show("Please select Student Type!");
                
            }

            string studentInfo =
                "Student ID: " + txtSid.Text +
                "\r\nStudent Name: " + txtSname.Text +
                "\r\nDepartment: " + txtDepartment.Text +
                "\r\nMark: " + mark +
                "\r\nStudent Type: " + studentType +
                "\r\n-----------------------------\r\n";

            File.AppendAllText(filePath, studentInfo);

            MessageBox.Show("Student information saved successfully!");
        }
    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSid.Clear();
            txtSname.Clear();
            txtDepartment.Clear();
            txtmark.Clear();

            rbUndergraduate.Checked = false;
            rbPostgaraduate.Checked = false;

            listdisply.Items.Clear();
        } 

        private void btnread_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\Eng Naima\Downloads\Students.txt";

            listdisply.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] data = File.ReadAllLines(filePath);

                foreach (string line in data)
                {
                    listdisply.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }
    }
    }


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

namespace Assigmen_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnewfile_Click(object sender, EventArgs e)
        {

            // example of Creating new file, writing the file
            //Import Class 
            StreamWriter Output_file;
            StreamWriter Output_file1;

            //using 3 process the file
            //Open the file - creating new file
            Output_file = File.CreateText("index.txt");
            Output_file1 = File.CreateText("Home.doc");


            //process the file -write the file
            Output_file.Write("Welcome to CA244");
            Output_file.Write("C# is  hard then the other programming langueage ");
            //process the file -writeline the file
            Output_file1.WriteLine("Data Structure hard");
            Output_file1.WriteLine(" java is easy");


            //close the file
            Output_file.Close();
            Output_file1.Close();
        }

        private void txtfilepath_Click(object sender, EventArgs e)
        {

            // example of Creating new file - using Path, writing the file
            //Import Class 
            StreamWriter Output_file;
            

            //using 3 process the file
            //Open the file - creating new file
            Output_file = File.CreateText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");


            //process the file -write the file
            Output_file.Write("Welcome to CA244");
            Output_file.Write("C# is  hard then the other programming langueage ");
            


            //close the file
            Output_file.Close();
            
        }

        private void txtappend_Click(object sender, EventArgs e)
        {

            // example of Append the file, writing the file
            //Import Class 
            StreamWriter Output_file;

            //using 3 process the file
            //Open the file - Append the file
            Output_file = File.AppendText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");



            //process the file -write the file
            Output_file.Write("Name : Naima Adam");
            Output_file.Write("ID :C1240632 ");
            


            //close the file
            Output_file.Close();
        }

        private void txtusingread_Click(object sender, EventArgs e)
        {
            //import class 
            StreamReader Reads;

            //open the file
            Reads = File.OpenText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");
            while (Reads.EndOfStream==false)
            { 
            char lines;
            lines = (char)Reads.Read();
            disply.Items.Add(lines);
        }
            //close
            Reads.Close();

        }

        private void txtfileusingreadline_Click(object sender, EventArgs e)
        {
            //example read the file
            StreamReader Reads;
            //open the file -reading the file
            Reads = File.OpenText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");


            //process the file - reading

            // creating variable to store the reading itams
            String lines;
            // loops reading all files items
            while (Reads.EndOfStream == false)
            {
                // assigned the variable
                lines = Reads.ReadLine();
                //Assignet listbox
                disply.Items.Add(lines);
            }

            
            //close the file
            Reads.Close();
        }

        private void txtfileusingreadtoend_Click(object sender, EventArgs e)
        {
            //import class 
            StreamReader Reads;

            //open the file
            Reads = File.OpenText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");

            //process the file - using readtoend
            string lines;
            lines = Reads.ReadToEnd();
            disply.Items.Add(lines);
            //close the file
            Reads.Close();
        }

        private void txtrusingreadall_Click(object sender, EventArgs e)
        {
            // not need to import class
            string lines;
            lines= File.ReadAllText(@"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");
            disply.Items.Add(lines);
            //not need the process the file
            //not need close

        }

        private void txtread_Click(object sender, EventArgs e)
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(
                @"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt");

            // Display the lines
            disply.Items.Clear();
            disply.Items.AddRange(lines);
        }

        private void txtdeleteitem_Click(object sender, EventArgs e)
        {
            // Specify the file path
            string path = @"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt";

            //Read all lines

            string[] lines = File.ReadAllLines(path);

            // Get item from TextBox
            string item = txtdeleteitem.Text;

            // Delete the selected item
            bool deleted = false;

            var result = lines.Where(line =>
            {
                if (!deleted && line == item)
                {
                    deleted = true;
                    return false;
                }
                return true;
            }).ToArray();

            // Write remaining items to file
            File.WriteAllLines(path, result);

            // Display remaining items
            disply.Items.Clear();
            disply.Items.AddRange(result);

            MessageBox.Show(deleted ? "Item deleted!" : "Item not found!");
        }

        private void txtdeletefile_Click(object sender, EventArgs e)
        {
            // Specify the file path
            string path = @"C:\Users\Eng Naima\Downloads\Tests_Files\index.txt";

            // Delete the file
            if (File.Exists(path))
            {
                File.Delete(path);
                disply.Items.Clear();
                MessageBox.Show("File deleted successfully!");
            }
        }
    }
    }


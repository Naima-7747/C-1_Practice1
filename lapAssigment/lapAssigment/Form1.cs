using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            decimal balance;
            int month;
            if (!
                decimal.TryParse(txtstarting.Text, out balance) || balance < 0)
            {
                MessageBox.Show("Enter a valid starting blance");
                return;

            }
            if (!
                int.TryParse(txtmonth.Text, out month) || month < 1)
            {
                MessageBox.Show("Enter a valid month");
                return;
            }
            const decimal INTEREST_RATE = 0.005m;
            listdisply.Items.Clear();
            for (int count = 1; count <= month; count++)
            {
                listdisply.Items.Add("The ending balance for month" + count + "is" + "" + balance.ToString("c"));
            }
            enddisplay.Text = balance.ToString("c");
        }

        private void lblendbalance_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstarting.Clear();
            txtmonth.Clear();
            enddisplay.Text=" ";
            listdisply.Items.Clear();

            txtstarting.Focus();
        }
    }
    }


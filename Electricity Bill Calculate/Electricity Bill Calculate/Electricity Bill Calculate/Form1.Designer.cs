namespace Electricity_Bill_Calculate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcustomername = new System.Windows.Forms.Label();
            this.lblpreviousreading = new System.Windows.Forms.Label();
            this.lblcurrentreading = new System.Windows.Forms.Label();
            this.lblpriceperunit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreviousreading = new System.Windows.Forms.TextBox();
            this.txtcurrentreading = new System.Windows.Forms.TextBox();
            this.txtpriceperunits = new System.Windows.Forms.TextBox();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.btncalculatebill = new System.Windows.Forms.Button();
            this.lbloutpu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcustomername
            // 
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(8, 74);
            this.lblcustomername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(173, 27);
            this.lblcustomername.TabIndex = 0;
            this.lblcustomername.Text = "Enter Customer  Name  :";
            // 
            // lblpreviousreading
            // 
            this.lblpreviousreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreviousreading.Location = new System.Drawing.Point(8, 120);
            this.lblpreviousreading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpreviousreading.Name = "lblpreviousreading";
            this.lblpreviousreading.Size = new System.Drawing.Size(173, 23);
            this.lblpreviousreading.TabIndex = 1;
            this.lblpreviousreading.Text = "Enter Previous Reading  :";
            this.lblpreviousreading.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcurrentreading
            // 
            this.lblcurrentreading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentreading.Location = new System.Drawing.Point(8, 161);
            this.lblcurrentreading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcurrentreading.Name = "lblcurrentreading";
            this.lblcurrentreading.Size = new System.Drawing.Size(173, 32);
            this.lblcurrentreading.TabIndex = 2;
            this.lblcurrentreading.Text = "Enter Current Reading  :";
            // 
            // lblpriceperunit
            // 
            this.lblpriceperunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriceperunit.Location = new System.Drawing.Point(-2, 202);
            this.lblpriceperunit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpriceperunit.Name = "lblpriceperunit";
            this.lblpriceperunit.Size = new System.Drawing.Size(173, 20);
            this.lblpriceperunit.TabIndex = 3;
            this.lblpriceperunit.Text = "Enter Price Per Unit ($) :";
            this.lblpriceperunit.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(148, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Electricity Bill Calculator";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtpreviousreading
            // 
            this.txtpreviousreading.Location = new System.Drawing.Point(197, 116);
            this.txtpreviousreading.Margin = new System.Windows.Forms.Padding(2);
            this.txtpreviousreading.Multiline = true;
            this.txtpreviousreading.Name = "txtpreviousreading";
            this.txtpreviousreading.Size = new System.Drawing.Size(166, 29);
            this.txtpreviousreading.TabIndex = 5;
            this.txtpreviousreading.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcurrentreading
            // 
            this.txtcurrentreading.Location = new System.Drawing.Point(197, 161);
            this.txtcurrentreading.Margin = new System.Windows.Forms.Padding(2);
            this.txtcurrentreading.Multiline = true;
            this.txtcurrentreading.Name = "txtcurrentreading";
            this.txtcurrentreading.Size = new System.Drawing.Size(172, 27);
            this.txtcurrentreading.TabIndex = 6;
            // 
            // txtpriceperunits
            // 
            this.txtpriceperunits.Location = new System.Drawing.Point(197, 202);
            this.txtpriceperunits.Margin = new System.Windows.Forms.Padding(2);
            this.txtpriceperunits.Multiline = true;
            this.txtpriceperunits.Name = "txtpriceperunits";
            this.txtpriceperunits.Size = new System.Drawing.Size(172, 25);
            this.txtpriceperunits.TabIndex = 7;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(197, 74);
            this.txtcustomername.Margin = new System.Windows.Forms.Padding(2);
            this.txtcustomername.Multiline = true;
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.ShortcutsEnabled = false;
            this.txtcustomername.Size = new System.Drawing.Size(166, 27);
            this.txtcustomername.TabIndex = 8;
            // 
            // btncalculatebill
            // 
            this.btncalculatebill.BackColor = System.Drawing.Color.Goldenrod;
            this.btncalculatebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btncalculatebill.Location = new System.Drawing.Point(171, 230);
            this.btncalculatebill.Margin = new System.Windows.Forms.Padding(2);
            this.btncalculatebill.Name = "btncalculatebill";
            this.btncalculatebill.Size = new System.Drawing.Size(149, 29);
            this.btncalculatebill.TabIndex = 9;
            this.btncalculatebill.Text = "Calculate Bill";
            this.btncalculatebill.UseVisualStyleBackColor = false;
            this.btncalculatebill.Click += new System.EventHandler(this.btncalculatebill_Click);
            // 
            // lbloutpu
            // 
            this.lbloutpu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbloutpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutpu.ForeColor = System.Drawing.Color.Black;
            this.lbloutpu.Location = new System.Drawing.Point(117, 270);
            this.lbloutpu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloutpu.Name = "lbloutpu";
            this.lbloutpu.Size = new System.Drawing.Size(321, 52);
            this.lbloutpu.TabIndex = 10;
            this.lbloutpu.Click += new System.EventHandler(this.lbloutpu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 443);
            this.Controls.Add(this.lbloutpu);
            this.Controls.Add(this.btncalculatebill);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.txtpriceperunits);
            this.Controls.Add(this.txtcurrentreading);
            this.Controls.Add(this.txtpreviousreading);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblpriceperunit);
            this.Controls.Add(this.lblcurrentreading);
            this.Controls.Add(this.lblpreviousreading);
            this.Controls.Add(this.lblcustomername);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.Label lblpreviousreading;
        private System.Windows.Forms.Label lblcurrentreading;
        private System.Windows.Forms.Label lblpriceperunit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreviousreading;
        private System.Windows.Forms.TextBox txtcurrentreading;
        private System.Windows.Forms.TextBox txtpriceperunits;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Button btncalculatebill;
        private System.Windows.Forms.Label lbloutpu;
    }
}


namespace Assigment_Student_Info
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
            this.lblstudentid = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lblsudentname = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblmark = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.rbPostgaraduate = new System.Windows.Forms.RadioButton();
            this.btnsavetofile = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listdisply = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblstudentid
            // 
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(12, 70);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(84, 23);
            this.lblstudentid.TabIndex = 0;
            this.lblstudentid.Text = "Student ID";
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(142, 73);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 20);
            this.txtSid.TabIndex = 1;
            // 
            // lblsudentname
            // 
            this.lblsudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsudentname.Location = new System.Drawing.Point(12, 112);
            this.lblsudentname.Name = "lblsudentname";
            this.lblsudentname.Size = new System.Drawing.Size(110, 20);
            this.lblsudentname.TabIndex = 2;
            this.lblsudentname.Text = "Stusent Name";
            // 
            // lbldepartment
            // 
            this.lbldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(12, 162);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(97, 20);
            this.lbldepartment.TabIndex = 3;
            this.lbldepartment.Text = "Department";
            // 
            // lblmark
            // 
            this.lblmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmark.Location = new System.Drawing.Point(12, 214);
            this.lblmark.Name = "lblmark";
            this.lblmark.Size = new System.Drawing.Size(52, 19);
            this.lblmark.TabIndex = 4;
            this.lblmark.Text = "Mark";
            this.lblmark.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(142, 112);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 20);
            this.txtSname.TabIndex = 5;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(142, 162);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 6;
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(142, 213);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(100, 20);
            this.txtmark.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Student Information";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Type";
            // 
            // rbUndergraduate
            // 
            this.rbUndergraduate.AutoSize = true;
            this.rbUndergraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUndergraduate.Location = new System.Drawing.Point(15, 309);
            this.rbUndergraduate.Name = "rbUndergraduate";
            this.rbUndergraduate.Size = new System.Drawing.Size(129, 20);
            this.rbUndergraduate.TabIndex = 10;
            this.rbUndergraduate.TabStop = true;
            this.rbUndergraduate.Text = "Undergraduate";
            this.rbUndergraduate.UseVisualStyleBackColor = true;
            // 
            // rbPostgaraduate
            // 
            this.rbPostgaraduate.AutoSize = true;
            this.rbPostgaraduate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPostgaraduate.Location = new System.Drawing.Point(15, 343);
            this.rbPostgaraduate.Name = "rbPostgaraduate";
            this.rbPostgaraduate.Size = new System.Drawing.Size(118, 20);
            this.rbPostgaraduate.TabIndex = 11;
            this.rbPostgaraduate.TabStop = true;
            this.rbPostgaraduate.Text = "Postgraduate";
            this.rbPostgaraduate.UseVisualStyleBackColor = true;
            // 
            // btnsavetofile
            // 
            this.btnsavetofile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsavetofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavetofile.Location = new System.Drawing.Point(30, 390);
            this.btnsavetofile.Name = "btnsavetofile";
            this.btnsavetofile.Size = new System.Drawing.Size(114, 48);
            this.btnsavetofile.TabIndex = 12;
            this.btnsavetofile.Text = "++++++++++++++++++++++++++++++++";
            this.btnsavetofile.UseVisualStyleBackColor = false;
            this.btnsavetofile.Click += new System.EventHandler(this.btnsavetofile_Click);
            // 
            // btnread
            // 
            this.btnread.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(234, 390);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(107, 48);
            this.btnread.TabIndex = 13;
            this.btnread.Text = "Read from file";
            this.btnread.UseVisualStyleBackColor = false;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(463, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 48);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(664, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Save Student Information";
            // 
            // listdisply
            // 
            this.listdisply.FormattingEnabled = true;
            this.listdisply.Location = new System.Drawing.Point(330, 70);
            this.listdisply.Name = "listdisply";
            this.listdisply.Size = new System.Drawing.Size(458, 290);
            this.listdisply.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listdisply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsavetofile);
            this.Controls.Add(this.rbPostgaraduate);
            this.Controls.Add(this.rbUndergraduate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblmark);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.lblsudentname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lblsudentname;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblmark;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPostgaraduate;
        internal System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.Button btnsavetofile;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listdisply;
    }
}


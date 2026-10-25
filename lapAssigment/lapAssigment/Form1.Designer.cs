namespace lapAssigment
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.listdisply = new System.Windows.Forms.ListBox();
            this.enddisplay = new System.Windows.Forms.Label();
            this.lblendbalance = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblStarting = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtstarting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(462, 373);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(263, 373);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(55, 373);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 17;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // listdisply
            // 
            this.listdisply.FormattingEnabled = true;
            this.listdisply.Location = new System.Drawing.Point(263, 131);
            this.listdisply.Name = "listdisply";
            this.listdisply.Size = new System.Drawing.Size(274, 121);
            this.listdisply.TabIndex = 16;
            // 
            // enddisplay
            // 
            this.enddisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enddisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddisplay.Location = new System.Drawing.Point(263, 267);
            this.enddisplay.Name = "enddisplay";
            this.enddisplay.Size = new System.Drawing.Size(274, 47);
            this.enddisplay.TabIndex = 15;
            // 
            // lblendbalance
            // 
            this.lblendbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblendbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendbalance.Location = new System.Drawing.Point(65, 282);
            this.lblendbalance.Name = "lblendbalance";
            this.lblendbalance.Size = new System.Drawing.Size(125, 23);
            this.lblendbalance.TabIndex = 14;
            this.lblendbalance.Text = "Ending Balance";
            this.lblendbalance.Click += new System.EventHandler(this.lblendbalance_Click);
            // 
            // lblmonth
            // 
            this.lblmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(56, 88);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(134, 24);
            this.lblmonth.TabIndex = 13;
            this.lblmonth.Text = "Number of Months";
            // 
            // lblStarting
            // 
            this.lblStarting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStarting.Location = new System.Drawing.Point(80, 27);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(110, 20);
            this.lblStarting.TabIndex = 12;
            this.lblStarting.Text = "Starting Balance";
            this.lblStarting.UseCompatibleTextRendering = true;
            // 
            // txtmonth
            // 
            this.txtmonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmonth.Location = new System.Drawing.Point(263, 92);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(274, 20);
            this.txtmonth.TabIndex = 11;
            // 
            // txtstarting
            // 
            this.txtstarting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstarting.Location = new System.Drawing.Point(263, 27);
            this.txtstarting.Name = "txtstarting";
            this.txtstarting.Size = new System.Drawing.Size(274, 20);
            this.txtstarting.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listdisply);
            this.Controls.Add(this.enddisplay);
            this.Controls.Add(this.lblendbalance);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lblStarting);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtstarting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListBox listdisply;
        private System.Windows.Forms.Label enddisplay;
        private System.Windows.Forms.Label lblendbalance;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtstarting;
    }
}


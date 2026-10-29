namespace Assigmen_File
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
            this.txtdeletefile = new System.Windows.Forms.Button();
            this.txtdeleteitem = new System.Windows.Forms.Button();
            this.txtread = new System.Windows.Forms.Button();
            this.disply = new System.Windows.Forms.ListBox();
            this.txtfileusingreadtoend = new System.Windows.Forms.Button();
            this.txtfileusingreadline = new System.Windows.Forms.Button();
            this.txtfilepath = new System.Windows.Forms.Button();
            this.txtrusingreadall = new System.Windows.Forms.Button();
            this.txtusingread = new System.Windows.Forms.Button();
            this.txtappend = new System.Windows.Forms.Button();
            this.txtnewfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdeletefile
            // 
            this.txtdeletefile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtdeletefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeletefile.Location = new System.Drawing.Point(378, 247);
            this.txtdeletefile.Name = "txtdeletefile";
            this.txtdeletefile.Size = new System.Drawing.Size(109, 83);
            this.txtdeletefile.TabIndex = 21;
            this.txtdeletefile.Text = "Delete file";
            this.txtdeletefile.UseVisualStyleBackColor = false;
            this.txtdeletefile.Click += new System.EventHandler(this.txtdeletefile_Click);
            // 
            // txtdeleteitem
            // 
            this.txtdeleteitem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtdeleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeleteitem.Location = new System.Drawing.Point(378, 125);
            this.txtdeleteitem.Name = "txtdeleteitem";
            this.txtdeleteitem.Size = new System.Drawing.Size(109, 86);
            this.txtdeleteitem.TabIndex = 20;
            this.txtdeleteitem.Text = "Dlelete item";
            this.txtdeleteitem.UseVisualStyleBackColor = false;
            this.txtdeleteitem.Click += new System.EventHandler(this.txtdeleteitem_Click);
            // 
            // txtread
            // 
            this.txtread.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtread.Location = new System.Drawing.Point(378, 13);
            this.txtread.Name = "txtread";
            this.txtread.Size = new System.Drawing.Size(109, 83);
            this.txtread.TabIndex = 19;
            this.txtread.Text = "Read";
            this.txtread.UseVisualStyleBackColor = false;
            this.txtread.Click += new System.EventHandler(this.txtread_Click);
            // 
            // disply
            // 
            this.disply.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.disply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disply.FormattingEnabled = true;
            this.disply.ItemHeight = 16;
            this.disply.Location = new System.Drawing.Point(493, 6);
            this.disply.Name = "disply";
            this.disply.Size = new System.Drawing.Size(391, 324);
            this.disply.TabIndex = 18;
            // 
            // txtfileusingreadtoend
            // 
            this.txtfileusingreadtoend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfileusingreadtoend.Location = new System.Drawing.Point(237, 219);
            this.txtfileusingreadtoend.Name = "txtfileusingreadtoend";
            this.txtfileusingreadtoend.Size = new System.Drawing.Size(108, 111);
            this.txtfileusingreadtoend.TabIndex = 17;
            this.txtfileusingreadtoend.Text = "Read the file using Readtoend";
            this.txtfileusingreadtoend.UseVisualStyleBackColor = true;
            this.txtfileusingreadtoend.Click += new System.EventHandler(this.txtfileusingreadtoend_Click);
            // 
            // txtfileusingreadline
            // 
            this.txtfileusingreadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfileusingreadline.Location = new System.Drawing.Point(237, 125);
            this.txtfileusingreadline.Name = "txtfileusingreadline";
            this.txtfileusingreadline.Size = new System.Drawing.Size(108, 67);
            this.txtfileusingreadline.TabIndex = 16;
            this.txtfileusingreadline.Text = "Read the file using Readline";
            this.txtfileusingreadline.UseVisualStyleBackColor = true;
            this.txtfileusingreadline.Click += new System.EventHandler(this.txtfileusingreadline_Click);
            // 
            // txtfilepath
            // 
            this.txtfilepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilepath.Location = new System.Drawing.Point(237, 12);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(108, 84);
            this.txtfilepath.TabIndex = 15;
            this.txtfilepath.Text = "Creating New file using Path";
            this.txtfilepath.UseVisualStyleBackColor = true;
            this.txtfilepath.Click += new System.EventHandler(this.txtfilepath_Click);
            // 
            // txtrusingreadall
            // 
            this.txtrusingreadall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrusingreadall.Location = new System.Drawing.Point(2, 369);
            this.txtrusingreadall.Name = "txtrusingreadall";
            this.txtrusingreadall.Size = new System.Drawing.Size(111, 69);
            this.txtrusingreadall.TabIndex = 14;
            this.txtrusingreadall.Text = "Read the file using ReadAll";
            this.txtrusingreadall.UseVisualStyleBackColor = true;
            this.txtrusingreadall.Click += new System.EventHandler(this.txtrusingreadall_Click);
            // 
            // txtusingread
            // 
            this.txtusingread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusingread.Location = new System.Drawing.Point(2, 219);
            this.txtusingread.Name = "txtusingread";
            this.txtusingread.Size = new System.Drawing.Size(111, 111);
            this.txtusingread.TabIndex = 13;
            this.txtusingread.Text = "Read the file using Read()";
            this.txtusingread.UseVisualStyleBackColor = true;
            this.txtusingread.Click += new System.EventHandler(this.txtusingread_Click);
            // 
            // txtappend
            // 
            this.txtappend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappend.Location = new System.Drawing.Point(10, 125);
            this.txtappend.Name = "txtappend";
            this.txtappend.Size = new System.Drawing.Size(103, 67);
            this.txtappend.TabIndex = 12;
            this.txtappend.Text = "Append";
            this.txtappend.UseVisualStyleBackColor = true;
            this.txtappend.Click += new System.EventHandler(this.txtappend_Click);
            // 
            // txtnewfile
            // 
            this.txtnewfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewfile.Location = new System.Drawing.Point(10, 12);
            this.txtnewfile.Name = "txtnewfile";
            this.txtnewfile.Size = new System.Drawing.Size(103, 84);
            this.txtnewfile.TabIndex = 11;
            this.txtnewfile.Text = "Creating New file";
            this.txtnewfile.UseVisualStyleBackColor = true;
            this.txtnewfile.Click += new System.EventHandler(this.txtnewfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.txtdeletefile);
            this.Controls.Add(this.txtdeleteitem);
            this.Controls.Add(this.txtread);
            this.Controls.Add(this.disply);
            this.Controls.Add(this.txtfileusingreadtoend);
            this.Controls.Add(this.txtfileusingreadline);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.txtrusingreadall);
            this.Controls.Add(this.txtusingread);
            this.Controls.Add(this.txtappend);
            this.Controls.Add(this.txtnewfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtdeletefile;
        private System.Windows.Forms.Button txtdeleteitem;
        private System.Windows.Forms.Button txtread;
        private System.Windows.Forms.ListBox disply;
        private System.Windows.Forms.Button txtfileusingreadtoend;
        private System.Windows.Forms.Button txtfileusingreadline;
        private System.Windows.Forms.Button txtfilepath;
        private System.Windows.Forms.Button txtrusingreadall;
        private System.Windows.Forms.Button txtusingread;
        private System.Windows.Forms.Button txtappend;
        private System.Windows.Forms.Button txtnewfile;
    }
}


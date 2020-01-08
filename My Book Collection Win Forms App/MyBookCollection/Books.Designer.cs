namespace MyBookCollection
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.EnterBooks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBooks = new System.Windows.Forms.Button();
            this.btnUpdateBooks = new System.Windows.Forms.Button();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Books Menu";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(184, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Return to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EnterBooks
            // 
            this.EnterBooks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EnterBooks.ForeColor = System.Drawing.Color.Navy;
            this.EnterBooks.Location = new System.Drawing.Point(76, 51);
            this.EnterBooks.Name = "EnterBooks";
            this.EnterBooks.Size = new System.Drawing.Size(112, 50);
            this.EnterBooks.TabIndex = 11;
            this.EnterBooks.Text = "Enter Books";
            this.EnterBooks.UseVisualStyleBackColor = true;
            this.EnterBooks.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteBooks);
            this.groupBox1.Controls.Add(this.btnUpdateBooks);
            this.groupBox1.Controls.Add(this.btnViewBooks);
            this.groupBox1.Controls.Add(this.EnterBooks);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 318);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnDeleteBooks
            // 
            this.btnDeleteBooks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteBooks.ForeColor = System.Drawing.Color.Navy;
            this.btnDeleteBooks.Location = new System.Drawing.Point(76, 221);
            this.btnDeleteBooks.Name = "btnDeleteBooks";
            this.btnDeleteBooks.Size = new System.Drawing.Size(112, 47);
            this.btnDeleteBooks.TabIndex = 14;
            this.btnDeleteBooks.Text = "Delete Books";
            this.btnDeleteBooks.UseVisualStyleBackColor = true;
            this.btnDeleteBooks.Click += new System.EventHandler(this.btnDeleteBooks_Click);
            // 
            // btnUpdateBooks
            // 
            this.btnUpdateBooks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateBooks.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateBooks.Location = new System.Drawing.Point(76, 166);
            this.btnUpdateBooks.Name = "btnUpdateBooks";
            this.btnUpdateBooks.Size = new System.Drawing.Size(112, 49);
            this.btnUpdateBooks.TabIndex = 13;
            this.btnUpdateBooks.Text = "Update Books";
            this.btnUpdateBooks.UseVisualStyleBackColor = true;
            this.btnUpdateBooks.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnViewBooks.ForeColor = System.Drawing.Color.Navy;
            this.btnViewBooks.Location = new System.Drawing.Point(76, 107);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(112, 53);
            this.btnViewBooks.TabIndex = 12;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.UseVisualStyleBackColor = true;
            this.btnViewBooks.Click += new System.EventHandler(this.button2_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 339);
            this.Controls.Add(this.groupBox1);
            this.Name = "Books";
            this.Text = "Manage Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button EnterBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.Button btnDeleteBooks;
        private System.Windows.Forms.Button btnUpdateBooks;


    }
}
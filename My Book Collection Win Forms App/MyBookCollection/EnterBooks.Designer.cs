namespace MyBookCollection
{
    partial class EnterBooks
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBTitle = new System.Windows.Forms.TextBox();
            this.txtBPName = new System.Windows.Forms.TextBox();
            this.txtBCType = new System.Windows.Forms.TextBox();
            this.txtBTopic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBNote = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBPPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBENumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBCYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBDPurchased = new System.Windows.Forms.TextBox();
            this.txtBPages = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBSNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CloseBooks = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.txtBAuthor = new System.Windows.Forms.ComboBox();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(0, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Publisher Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(61, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Topic";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cover Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBTitle
            // 
            this.txtBTitle.Location = new System.Drawing.Point(134, 19);
            this.txtBTitle.Name = "txtBTitle";
            this.txtBTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBTitle.TabIndex = 4;
            // 
            // txtBPName
            // 
            this.txtBPName.Location = new System.Drawing.Point(134, 86);
            this.txtBPName.Name = "txtBPName";
            this.txtBPName.Size = new System.Drawing.Size(100, 20);
            this.txtBPName.TabIndex = 5;
            this.txtBPName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtBCType
            // 
            this.txtBCType.Location = new System.Drawing.Point(134, 115);
            this.txtBCType.Name = "txtBCType";
            this.txtBCType.Size = new System.Drawing.Size(100, 20);
            this.txtBCType.TabIndex = 6;
            // 
            // txtBTopic
            // 
            this.txtBTopic.FormattingEnabled = true;
            this.txtBTopic.Location = new System.Drawing.Point(134, 50);
            this.txtBTopic.Name = "txtBTopic";
            this.txtBTopic.Size = new System.Drawing.Size(100, 21);
            this.txtBTopic.TabIndex = 7;
            this.txtBTopic.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(64, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBNote
            // 
            this.txtBNote.Location = new System.Drawing.Point(134, 152);
            this.txtBNote.Multiline = true;
            this.txtBNote.Name = "txtBNote";
            this.txtBNote.Size = new System.Drawing.Size(100, 66);
            this.txtBNote.TabIndex = 9;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(255, 262);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(3, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Purchase Price";
            // 
            // txtBPPrice
            // 
            this.txtBPPrice.Location = new System.Drawing.Point(134, 224);
            this.txtBPPrice.Name = "txtBPPrice";
            this.txtBPPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBPPrice.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(300, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edition Number";
            // 
            // txtBENumber
            // 
            this.txtBENumber.Location = new System.Drawing.Point(421, 19);
            this.txtBENumber.Name = "txtBENumber";
            this.txtBENumber.Size = new System.Drawing.Size(100, 20);
            this.txtBENumber.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(300, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Copyright Year";
            // 
            // txtBCYear
            // 
            this.txtBCYear.Location = new System.Drawing.Point(421, 53);
            this.txtBCYear.Name = "txtBCYear";
            this.txtBCYear.Size = new System.Drawing.Size(100, 20);
            this.txtBCYear.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(300, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Date Purchased";
            // 
            // txtBDPurchased
            // 
            this.txtBDPurchased.Location = new System.Drawing.Point(421, 86);
            this.txtBDPurchased.Name = "txtBDPurchased";
            this.txtBDPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtBDPurchased.TabIndex = 18;
            // 
            // txtBPages
            // 
            this.txtBPages.Location = new System.Drawing.Point(421, 118);
            this.txtBPages.Name = "txtBPages";
            this.txtBPages.Size = new System.Drawing.Size(100, 20);
            this.txtBPages.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(362, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Pages";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(318, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Shelf Number";
            // 
            // txtBSNo
            // 
            this.txtBSNo.Location = new System.Drawing.Point(421, 152);
            this.txtBSNo.Name = "txtBSNo";
            this.txtBSNo.Size = new System.Drawing.Size(100, 20);
            this.txtBSNo.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBSNo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBPages);
            this.groupBox1.Controls.Add(this.txtBDPurchased);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBCYear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBENumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBPPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBTopic);
            this.groupBox1.Controls.Add(this.txtBCType);
            this.groupBox1.Controls.Add(this.txtBPName);
            this.groupBox1.Controls.Add(this.txtBTitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 255);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Books";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CloseBooks
            // 
            this.CloseBooks.Location = new System.Drawing.Point(443, 303);
            this.CloseBooks.Name = "CloseBooks";
            this.CloseBooks.Size = new System.Drawing.Size(90, 23);
            this.CloseBooks.TabIndex = 31;
            this.CloseBooks.Text = "Close";
            this.CloseBooks.UseVisualStyleBackColor = true;
            this.CloseBooks.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(458, 274);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 30;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(377, 274);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 29;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBAuthor
            // 
            this.txtBAuthor.FormattingEnabled = true;
            this.txtBAuthor.Location = new System.Drawing.Point(146, 262);
            this.txtBAuthor.Name = "txtBAuthor";
            this.txtBAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtBAuthor.TabIndex = 33;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BookAuthor.Location = new System.Drawing.Point(73, 262);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(57, 23);
            this.BookAuthor.TabIndex = 32;
            this.BookAuthor.Text = "Author";
            // 
            // EnterBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 342);
            this.Controls.Add(this.txtBAuthor);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.CloseBooks);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "EnterBooks";
            this.Text = "Book Record";
            this.Load += new System.EventHandler(this.EnterBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBTitle;
        private System.Windows.Forms.TextBox txtBPName;
        private System.Windows.Forms.TextBox txtBCType;
        private System.Windows.Forms.ComboBox txtBTopic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBNote;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBPPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBENumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBCYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBDPurchased;
        private System.Windows.Forms.TextBox txtBPages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBSNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CloseBooks;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox txtBAuthor;
        private System.Windows.Forms.Label BookAuthor;
    }
}
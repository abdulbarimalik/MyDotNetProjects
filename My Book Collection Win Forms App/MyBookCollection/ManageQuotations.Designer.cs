namespace MyBookCollection
{
    partial class ManageQuotations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateQuotations = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnterQuote = new System.Windows.Forms.Button();
            this.btnVQuote = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateQuotations);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEnterQuote);
            this.groupBox1.Controls.Add(this.btnVQuote);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateQuotations
            // 
            this.btnUpdateQuotations.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateQuotations.ForeColor = System.Drawing.Color.Navy;
            this.btnUpdateQuotations.Location = new System.Drawing.Point(232, 59);
            this.btnUpdateQuotations.Name = "btnUpdateQuotations";
            this.btnUpdateQuotations.Size = new System.Drawing.Size(125, 56);
            this.btnUpdateQuotations.TabIndex = 15;
            this.btnUpdateQuotations.Text = "Update Quotations";
            this.btnUpdateQuotations.UseVisualStyleBackColor = true;
            this.btnUpdateQuotations.Click += new System.EventHandler(this.btnUpdateQuotations_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.ForeColor = System.Drawing.Color.Navy;
            this.btnDelete.Location = new System.Drawing.Point(232, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 56);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Quotations";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnterQuote
            // 
            this.btnEnterQuote.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEnterQuote.ForeColor = System.Drawing.Color.Navy;
            this.btnEnterQuote.Location = new System.Drawing.Point(76, 59);
            this.btnEnterQuote.Name = "btnEnterQuote";
            this.btnEnterQuote.Size = new System.Drawing.Size(125, 56);
            this.btnEnterQuote.TabIndex = 13;
            this.btnEnterQuote.Text = "Enter Quotations";
            this.btnEnterQuote.UseVisualStyleBackColor = true;
            this.btnEnterQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVQuote
            // 
            this.btnVQuote.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnVQuote.ForeColor = System.Drawing.Color.Navy;
            this.btnVQuote.Location = new System.Drawing.Point(76, 158);
            this.btnVQuote.Name = "btnVQuote";
            this.btnVQuote.Size = new System.Drawing.Size(125, 56);
            this.btnVQuote.TabIndex = 12;
            this.btnVQuote.Text = "View Quotations";
            this.btnVQuote.UseVisualStyleBackColor = true;
            this.btnVQuote.Click += new System.EventHandler(this.btnVQuote_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(292, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Return to Main Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(114, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Quotations Menu";
            // 
            // ManageQuotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 351);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageQuotations";
            this.Text = "ManageQuotations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEnterQuote;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVQuote;
        private System.Windows.Forms.Button btnUpdateQuotations;

    }
}
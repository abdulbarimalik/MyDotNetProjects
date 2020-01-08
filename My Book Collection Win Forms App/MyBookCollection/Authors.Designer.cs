namespace MyBookCollection
{
    partial class Authors
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDAuthor = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.btnVAuthor = new System.Windows.Forms.Button();
            this.btnEAuthor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnDAuthor);
            this.groupBox2.Controls.Add(this.Close);
            this.groupBox2.Controls.Add(this.btnVAuthor);
            this.groupBox2.Controls.Add(this.btnEAuthor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 302);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(50, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Author";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDAuthor
            // 
            this.btnDAuthor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDAuthor.ForeColor = System.Drawing.Color.Navy;
            this.btnDAuthor.Location = new System.Drawing.Point(50, 219);
            this.btnDAuthor.Name = "btnDAuthor";
            this.btnDAuthor.Size = new System.Drawing.Size(123, 40);
            this.btnDAuthor.TabIndex = 7;
            this.btnDAuthor.Text = "Delete Author";
            this.btnDAuthor.UseVisualStyleBackColor = true;
            this.btnDAuthor.Click += new System.EventHandler(this.btnDAuthor_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Close.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Close.Location = new System.Drawing.Point(167, 267);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(149, 29);
            this.Close.TabIndex = 6;
            this.Close.Text = "Return to Previous Menu";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVAuthor
            // 
            this.btnVAuthor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnVAuthor.ForeColor = System.Drawing.Color.Navy;
            this.btnVAuthor.Location = new System.Drawing.Point(50, 122);
            this.btnVAuthor.Name = "btnVAuthor";
            this.btnVAuthor.Size = new System.Drawing.Size(123, 41);
            this.btnVAuthor.TabIndex = 4;
            this.btnVAuthor.Text = "View Author";
            this.btnVAuthor.UseVisualStyleBackColor = true;
            this.btnVAuthor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEAuthor
            // 
            this.btnEAuthor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEAuthor.ForeColor = System.Drawing.Color.Navy;
            this.btnEAuthor.Location = new System.Drawing.Point(50, 72);
            this.btnEAuthor.Name = "btnEAuthor";
            this.btnEAuthor.Size = new System.Drawing.Size(123, 44);
            this.btnEAuthor.TabIndex = 3;
            this.btnEAuthor.Text = "Enter Author";
            this.btnEAuthor.UseVisualStyleBackColor = true;
            this.btnEAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(46, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Authors Menu";
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.groupBox2);
            this.Name = "Authors";
            this.Text = "Authors";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVAuthor;
        private System.Windows.Forms.Button btnEAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnDAuthor;
        private System.Windows.Forms.Button button1;

    }
}
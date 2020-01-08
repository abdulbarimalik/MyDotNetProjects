namespace MyBookCollection
{
    partial class PreviewReports
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
            this.Close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRpt1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Close);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnRpt1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Reports";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Close.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Close.Location = new System.Drawing.Point(148, 282);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(149, 29);
            this.Close.TabIndex = 7;
            this.Close.Text = "Return to Previous Menu";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(36, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "Preview the Quotes by Author Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRpt1
            // 
            this.btnRpt1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRpt1.Location = new System.Drawing.Point(36, 19);
            this.btnRpt1.Name = "btnRpt1";
            this.btnRpt1.Size = new System.Drawing.Size(131, 66);
            this.btnRpt1.TabIndex = 0;
            this.btnRpt1.Text = "Preview the Titles by Author Report";
            this.btnRpt1.UseVisualStyleBackColor = true;
            this.btnRpt1.Click += new System.EventHandler(this.btnRpt1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(36, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Preview the Titles by Topic Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreviewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 350);
            this.Controls.Add(this.groupBox1);
            this.Name = "PreviewReports";
            this.Text = "PreviewReports";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRpt1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
    }
}
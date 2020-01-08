namespace MyBookCollection
{
    partial class TopicsMenu
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
            this.btnDel_Topic = new System.Windows.Forms.Button();
            this.btnEdit_Topic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVTopics = new System.Windows.Forms.Button();
            this.btnETopics = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel_Topic);
            this.groupBox2.Controls.Add(this.btnEdit_Topic);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnVTopics);
            this.groupBox2.Controls.Add(this.btnETopics);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 366);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnDel_Topic
            // 
            this.btnDel_Topic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDel_Topic.ForeColor = System.Drawing.Color.Navy;
            this.btnDel_Topic.Location = new System.Drawing.Point(59, 245);
            this.btnDel_Topic.Name = "btnDel_Topic";
            this.btnDel_Topic.Size = new System.Drawing.Size(121, 59);
            this.btnDel_Topic.TabIndex = 14;
            this.btnDel_Topic.Text = "Delete Topics";
            this.btnDel_Topic.UseVisualStyleBackColor = true;
            this.btnDel_Topic.Click += new System.EventHandler(this.btnDel_Topic_Click);
            // 
            // btnEdit_Topic
            // 
            this.btnEdit_Topic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEdit_Topic.ForeColor = System.Drawing.Color.Navy;
            this.btnEdit_Topic.Location = new System.Drawing.Point(59, 180);
            this.btnEdit_Topic.Name = "btnEdit_Topic";
            this.btnEdit_Topic.Size = new System.Drawing.Size(121, 59);
            this.btnEdit_Topic.TabIndex = 13;
            this.btnEdit_Topic.Text = "Edit Topics";
            this.btnEdit_Topic.UseVisualStyleBackColor = true;
            this.btnEdit_Topic.Click += new System.EventHandler(this.btnEdit_Topic_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(211, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Return to Previous Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVTopics
            // 
            this.btnVTopics.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnVTopics.ForeColor = System.Drawing.Color.Navy;
            this.btnVTopics.Location = new System.Drawing.Point(59, 115);
            this.btnVTopics.Name = "btnVTopics";
            this.btnVTopics.Size = new System.Drawing.Size(121, 59);
            this.btnVTopics.TabIndex = 11;
            this.btnVTopics.Text = "View Topics";
            this.btnVTopics.UseVisualStyleBackColor = true;
            this.btnVTopics.Click += new System.EventHandler(this.btnVTopics_Click);
            // 
            // btnETopics
            // 
            this.btnETopics.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnETopics.ForeColor = System.Drawing.Color.Navy;
            this.btnETopics.Location = new System.Drawing.Point(59, 53);
            this.btnETopics.Name = "btnETopics";
            this.btnETopics.Size = new System.Drawing.Size(121, 56);
            this.btnETopics.TabIndex = 10;
            this.btnETopics.Text = "Enter Topics";
            this.btnETopics.UseVisualStyleBackColor = true;
            this.btnETopics.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(81, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Topics Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TopicsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TopicsMenu";
            this.Text = "TopicsMenu";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVTopics;
        private System.Windows.Forms.Button btnETopics;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDel_Topic;
        private System.Windows.Forms.Button btnEdit_Topic;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}
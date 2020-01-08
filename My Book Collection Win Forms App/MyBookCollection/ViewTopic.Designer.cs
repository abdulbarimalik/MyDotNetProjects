namespace MyBookCollection
{
    partial class ViewTopic
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
            this.Searchbtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.ComboBox();
            this.view1databtn = new System.Windows.Forms.Button();
            this.viewallbtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(360, 346);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(95, 29);
            this.Searchbtn.TabIndex = 9;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.SearchBox.FormattingEnabled = true;
            this.SearchBox.Location = new System.Drawing.Point(201, 351);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(137, 21);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.SelectedIndexChanged += new System.EventHandler(this.SearchBox_SelectedIndexChanged);
            // 
            // view1databtn
            // 
            this.view1databtn.Location = new System.Drawing.Point(297, 418);
            this.view1databtn.Name = "view1databtn";
            this.view1databtn.Size = new System.Drawing.Size(105, 40);
            this.view1databtn.TabIndex = 7;
            this.view1databtn.Text = "View Spacific Data";
            this.view1databtn.UseVisualStyleBackColor = true;
            this.view1databtn.Click += new System.EventHandler(this.view1databtn_Click);
            // 
            // viewallbtn
            // 
            this.viewallbtn.Location = new System.Drawing.Point(172, 418);
            this.viewallbtn.Name = "viewallbtn";
            this.viewallbtn.Size = new System.Drawing.Size(87, 40);
            this.viewallbtn.TabIndex = 6;
            this.viewallbtn.Text = "View All Data";
            this.viewallbtn.UseVisualStyleBackColor = true;
            this.viewallbtn.Click += new System.EventHandler(this.viewallbtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 74);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(365, 243);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "View Topic";
            // 
            // ViewTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.view1databtn);
            this.Controls.Add(this.viewallbtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "ViewTopic";
            this.Text = "Topic";
            this.Load += new System.EventHandler(this.ViewTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ComboBox SearchBox;
        private System.Windows.Forms.Button view1databtn;
        private System.Windows.Forms.Button viewallbtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;


    }
}
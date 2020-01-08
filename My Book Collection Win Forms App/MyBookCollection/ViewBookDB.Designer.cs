namespace MyBookCollection
{
    partial class ViewBookDB
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
            this.BooksGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksGridView
            // 
            this.BooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksGridView.Location = new System.Drawing.Point(0, 0);
            this.BooksGridView.Name = "BooksGridView";
            this.BooksGridView.Size = new System.Drawing.Size(350, 279);
            this.BooksGridView.TabIndex = 1;
            // 
            // ViewBookDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 279);
            this.Controls.Add(this.BooksGridView);
            this.Name = "ViewBookDB";
            this.Text = "ViewBookDB";
            this.Load += new System.EventHandler(this.ViewBookDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksGridView;
    }
}
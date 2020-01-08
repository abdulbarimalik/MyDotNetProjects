namespace MyBookCollection
{
    partial class ReportTitlesByTopic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTitlesByTopic));
            this.SPRptQuoteByAuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new MyBookCollection.DataSet1();
            this.SPPptTitleByAuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new MyBookCollection.DataSet2();
            this.SPPptTitleByAuthorTableAdapter = new MyBookCollection.DataSet2TableAdapters.SPPptTitleByAuthorTableAdapter();
            this.tableAdapterManager1 = new MyBookCollection.DataSet2TableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new MyBookCollection.DataSet2TableAdapters.TableAdapterManager();
            this.dataSet3 = new MyBookCollection.DataSet3();
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SPRptQuoteByAuthorTableAdapter = new MyBookCollection.DataSet1TableAdapters.SPRptQuoteByAuthorTableAdapter();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.printForm2 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SPRptQuoteByAuthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPPptTitleByAuthorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SPRptQuoteByAuthorBindingSource
            // 
            this.SPRptQuoteByAuthorBindingSource.DataMember = "SPRptQuoteByAuthor";
            this.SPRptQuoteByAuthorBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPPptTitleByAuthorBindingSource
            // 
            this.SPPptTitleByAuthorBindingSource.DataMember = "SPPptTitleByAuthor";
            this.SPPptTitleByAuthorBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPPptTitleByAuthorTableAdapter
            // 
            this.SPPptTitleByAuthorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = MyBookCollection.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = MyBookCollection.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // SPRptQuoteByAuthorTableAdapter
            // 
            this.SPRptQuoteByAuthorTableAdapter.ClearBeforeFill = true;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // printForm2
            // 
            this.printForm2.DocumentName = "document";
            this.printForm2.Form = this;
            this.printForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm2.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm2.PrinterSettings")));
            this.printForm2.PrintFileName = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet3BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReportTitlesByTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportTitlesByTopic";
            this.Text = "ReportTitlesByTopic";
            this.Load += new System.EventHandler(this.ReportTitlesByTopic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SPRptQuoteByAuthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPPptTitleByAuthorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SPPptTitleByAuthorBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.SPPptTitleByAuthorTableAdapter SPPptTitleByAuthorTableAdapter;
        private System.Windows.Forms.BindingSource SPRptQuoteByAuthorBindingSource;
        private DataSet1 DataSet1;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private DataSet1TableAdapters.SPRptQuoteByAuthorTableAdapter SPRptQuoteByAuthorTableAdapter;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
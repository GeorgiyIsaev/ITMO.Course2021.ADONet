namespace Lab04.Ex05.WorkingDataTable
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.FillTableButton = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.northwindDataSet1 = new Lab04.Ex05.WorkingDataTable.NorthwindDataSet();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.UpdateValueButton = new System.Windows.Forms.Button();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.RejectChangesButton = new System.Windows.Forms.Button();
            this.CellValueTextBox = new System.Windows.Forms.TextBox();
            this.OriginalDRVTextBox = new System.Windows.Forms.TextBox();
            this.RowStateTextBox = new System.Windows.Forms.TextBox();
            this.CurrentDRVTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(13, 13);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(445, 150);
            this.CustomersDataGridView.TabIndex = 0;
            this.CustomersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDataGridView_CellContentClick);
            // 
            // FillTableButton
            // 
            this.FillTableButton.Location = new System.Drawing.Point(13, 170);
            this.FillTableButton.Name = "FillTableButton";
            this.FillTableButton.Size = new System.Drawing.Size(75, 23);
            this.FillTableButton.TabIndex = 1;
            this.FillTableButton.Text = "Fill Table";
            this.FillTableButton.UseVisualStyleBackColor = true;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.Int, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NChar, 0, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NChar, 0, "ContactName"),
            new System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NChar, 0, "ContactTitle"),
            new System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NChar, 0, "Address"),
            new System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, "City"),
            new System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NChar, 0, "Region"),
            new System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NChar, 0, "PostalCode"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NChar, 0, "Country"),
            new System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NChar, 0, "Phone"),
            new System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NChar, 0, "Fax")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("ContactName", "ContactName"),
                        new System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Region", "Region"),
                        new System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"),
                        new System.Data.Common.DataColumnMapping("Country", "Country"),
                        new System.Data.Common.DataColumnMapping("Phone", "Phone"),
                        new System.Data.Common.DataColumnMapping("Fax", "Fax")})});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=USER-ПК\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True" +
    "";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DeleteRowButton.Location = new System.Drawing.Point(94, 170);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRowButton.TabIndex = 2;
            this.DeleteRowButton.Text = "DeleteRowButton";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // UpdateValueButton
            // 
            this.UpdateValueButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UpdateValueButton.Location = new System.Drawing.Point(12, 199);
            this.UpdateValueButton.Name = "UpdateValueButton";
            this.UpdateValueButton.Size = new System.Drawing.Size(157, 23);
            this.UpdateValueButton.TabIndex = 3;
            this.UpdateValueButton.Text = "Update Value";
            this.UpdateValueButton.UseVisualStyleBackColor = true;
            this.UpdateValueButton.Click += new System.EventHandler(this.UpdateValueButton_Click);
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AcceptChangesButton.Location = new System.Drawing.Point(12, 228);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(157, 23);
            this.AcceptChangesButton.TabIndex = 4;
            this.AcceptChangesButton.Text = "Accept Changes";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButton_Click);
            // 
            // RejectChangesButton
            // 
            this.RejectChangesButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RejectChangesButton.Location = new System.Drawing.Point(12, 257);
            this.RejectChangesButton.Name = "RejectChangesButton";
            this.RejectChangesButton.Size = new System.Drawing.Size(157, 23);
            this.RejectChangesButton.TabIndex = 5;
            this.RejectChangesButton.Text = "Reject Changes";
            this.RejectChangesButton.UseVisualStyleBackColor = true;
            this.RejectChangesButton.Click += new System.EventHandler(this.RejectChangesButton_Click);
            // 
            // CellValueTextBox
            // 
            this.CellValueTextBox.Location = new System.Drawing.Point(194, 173);
            this.CellValueTextBox.Name = "CellValueTextBox";
            this.CellValueTextBox.Size = new System.Drawing.Size(129, 20);
            this.CellValueTextBox.TabIndex = 6;
            // 
            // OriginalDRVTextBox
            // 
            this.OriginalDRVTextBox.Location = new System.Drawing.Point(329, 172);
            this.OriginalDRVTextBox.Name = "OriginalDRVTextBox";
            this.OriginalDRVTextBox.Size = new System.Drawing.Size(129, 20);
            this.OriginalDRVTextBox.TabIndex = 7;
            // 
            // RowStateTextBox
            // 
            this.RowStateTextBox.Location = new System.Drawing.Point(329, 198);
            this.RowStateTextBox.Name = "RowStateTextBox";
            this.RowStateTextBox.Size = new System.Drawing.Size(129, 20);
            this.RowStateTextBox.TabIndex = 9;
            // 
            // CurrentDRVTextBox
            // 
            this.CurrentDRVTextBox.Location = new System.Drawing.Point(194, 199);
            this.CurrentDRVTextBox.Name = "CurrentDRVTextBox";
            this.CurrentDRVTextBox.Size = new System.Drawing.Size(129, 20);
            this.CurrentDRVTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 299);
            this.Controls.Add(this.RowStateTextBox);
            this.Controls.Add(this.CurrentDRVTextBox);
            this.Controls.Add(this.OriginalDRVTextBox);
            this.Controls.Add(this.CellValueTextBox);
            this.Controls.Add(this.RejectChangesButton);
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.UpdateValueButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.FillTableButton);
            this.Controls.Add(this.CustomersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.Button FillTableButton;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button UpdateValueButton;
        private System.Windows.Forms.Button AcceptChangesButton;
        private System.Windows.Forms.Button RejectChangesButton;
        private System.Windows.Forms.TextBox CellValueTextBox;
        private System.Windows.Forms.TextBox OriginalDRVTextBox;
        private System.Windows.Forms.TextBox RowStateTextBox;
        private System.Windows.Forms.TextBox CurrentDRVTextBox;
    }
}


namespace Lab06.Ex01.SavingDataSetXml
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.CustomersAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.OrdersAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.northwindDataSet1 = new Lab06.Ex01.SavingDataSetXml.NorthwindDataSet();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.FillDataSetButton = new System.Windows.Forms.Button();
            this.SaveXmlDataButton = new System.Windows.Forms.Button();
            this.SaveXmlSchemaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
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
            // CustomersAdapter
            // 
            this.CustomersAdapter.InsertCommand = this.sqlInsertCommand1;
            this.CustomersAdapter.SelectCommand = this.sqlSelectCommand1;
            this.CustomersAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT * FROM Orders";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [Orders] ([Id], [NameOrder], [OrdYear], [CategoryName]) VALUES (@Id, " +
    "@NameOrder, @OrdYear, @CategoryName)";
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, "Id"),
            new System.Data.SqlClient.SqlParameter("@NameOrder", System.Data.SqlDbType.NChar, 0, "NameOrder"),
            new System.Data.SqlClient.SqlParameter("@OrdYear", System.Data.SqlDbType.NChar, 0, "OrdYear"),
            new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NChar, 0, "CategoryName")});
            // 
            // OrdersAdapter
            // 
            this.OrdersAdapter.InsertCommand = this.sqlInsertCommand2;
            this.OrdersAdapter.SelectCommand = this.sqlSelectCommand2;
            this.OrdersAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("NameOrder", "NameOrder"),
                        new System.Data.Common.DataColumnMapping("OrdYear", "OrdYear"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName")})});
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(13, 13);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(464, 181);
            this.CustomersGrid.TabIndex = 0;
            // 
            // FillDataSetButton
            // 
            this.FillDataSetButton.Location = new System.Drawing.Point(13, 201);
            this.FillDataSetButton.Name = "FillDataSetButton";
            this.FillDataSetButton.Size = new System.Drawing.Size(152, 23);
            this.FillDataSetButton.TabIndex = 1;
            this.FillDataSetButton.Text = "Fill";
            this.FillDataSetButton.UseVisualStyleBackColor = true;
            this.FillDataSetButton.Click += new System.EventHandler(this.FillDataSetButton_Click);
            // 
            // SaveXmlDataButton
            // 
            this.SaveXmlDataButton.Location = new System.Drawing.Point(171, 201);
            this.SaveXmlDataButton.Name = "SaveXmlDataButton";
            this.SaveXmlDataButton.Size = new System.Drawing.Size(152, 23);
            this.SaveXmlDataButton.TabIndex = 2;
            this.SaveXmlDataButton.Text = "Save XML Data";
            this.SaveXmlDataButton.UseVisualStyleBackColor = true;
            this.SaveXmlDataButton.Click += new System.EventHandler(this.SaveXmlDataButton_Click);
            // 
            // SaveXmlSchemaButton
            // 
            this.SaveXmlSchemaButton.Location = new System.Drawing.Point(329, 201);
            this.SaveXmlSchemaButton.Name = "SaveXmlSchemaButton";
            this.SaveXmlSchemaButton.Size = new System.Drawing.Size(152, 23);
            this.SaveXmlSchemaButton.TabIndex = 3;
            this.SaveXmlSchemaButton.Text = "Save XML Schema";
            this.SaveXmlSchemaButton.UseVisualStyleBackColor = true;
            this.SaveXmlSchemaButton.Click += new System.EventHandler(this.SaveXmlSchemaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 285);
            this.Controls.Add(this.SaveXmlSchemaButton);
            this.Controls.Add(this.SaveXmlDataButton);
            this.Controls.Add(this.FillDataSetButton);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter CustomersAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlDataAdapter OrdersAdapter;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Button FillDataSetButton;
        private System.Windows.Forms.Button SaveXmlDataButton;
        private System.Windows.Forms.Button SaveXmlSchemaButton;
    }
}


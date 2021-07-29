using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04.Ex06.DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView customersDataView;
        DataView ordersDataView;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            CustomersGrid.DataSource = customersDataView;

            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;
            DataRowView newCustomRow = customersDataView.AddNew();

            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            newCustomRow.EndEdit();

        }
    }
}

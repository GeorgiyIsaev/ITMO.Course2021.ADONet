using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONet.Zachet
{
    public partial class OwnerRegistrForm : Form
    {
        public OwnerRegistrForm(string DocumentNumber)
        {
            InitializeComponent();
            textBox_OwnerNumberDoc.Text = DocumentNumber;
        }

        private void OwnerRegistrForm_Load(object sender, EventArgs e)
        {
            textBox_OwnerNumberDoc.Enabled = false;

      
        }
    }
}

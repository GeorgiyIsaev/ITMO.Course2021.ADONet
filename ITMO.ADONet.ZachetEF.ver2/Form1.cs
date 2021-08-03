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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_vievPet_Click(object sender, EventArgs e)
        {
            //DataGridView_PetsList.DataSource = DataSet1.Owner;


            //DataGridView_PetsList.add
        }

        private void button_VievOwner_Click(object sender, EventArgs e)
        {

        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            RegisterPet form = new RegisterPet();
            form.Show();
        }
    }
}

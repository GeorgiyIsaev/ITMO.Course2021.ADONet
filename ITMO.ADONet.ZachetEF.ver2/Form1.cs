using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void button_vievPet_Click(object sender, EventArgs e)
        {
       
        }

        private void button_VievOwner_Click(object sender, EventArgs e)
        {

        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            RegisterPet form = new RegisterPet();
            form.Show();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            SP.context = new SampleContext();
            DataGridView_PetsList.DataSource = SP.context.Pets.ToList();
        }
    }
}

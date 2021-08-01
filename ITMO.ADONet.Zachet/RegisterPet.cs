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
    public partial class RegisterPet : Form
    {
        public RegisterPet()
        {
            InitializeComponent();
        }

       
        private void RegisterPet_Load(object sender, EventArgs e)
        {
            textBox_OwnerName.Enabled = false;
            textBox_OwnerSurName.Enabled = false;
            textBox_Email.Enabled = false;
            textBox_Telefon.Enabled = false;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (textBox_OwnerNumberDoc.Text == "123") 
            {
                textBox_OwnerNumberDoc.Enabled = false;
                textBox_OwnerName.Enabled = true;
                textBox_OwnerSurName.Enabled = true;
                textBox_Email.Enabled = true;
                textBox_Telefon.Enabled = true;
            }
        }

        private bool CheckFullText()
        {
       
            if (textBox_OwnerNumberDoc.Text == "") { return false; }
            if (textBox_OwnerName.Text == "") { return false; }
            if (textBox_OwnerSurName.Text == "") { return false; }
            if (textBox_Email.Text == "") { return false; }
            if (textBox_Telefon.Text == "") { return false; }

            if (textBox_NamePet.Text == "") { return false; }
          
            if (comboBox_TypePet.SelectedItem != null || comboBox_BreedPet.SelectedItem != null)
            { return false; }    

            return true;
        }
            //textBox_OwnerName
            //textBox_OwnerSurName
            //textBox_Email
            //textBox_Telefon
            //comboBox_TypePet
            //comboBox_BreedPet
            //textBox_NamePet
            //dateTimePicker_registr

        private void button_registr_Click(object sender, EventArgs e)
        {
            if (!CheckFullText())
            {
                MessageBox.Show("Не все поля заполнены!");
            }

        }
    }
}

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

        private void button_registr_Click(object sender, EventArgs e)
        {
            if(textBox_OwnerName.Text == "" ||
                    textBox_OwnerSurName.Text == "" ||
                    textBox_OwnerNumberDoc.Text == "" ||
                    textBox_Email.Text == "" ||
                    textBox_Telefon.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }



            try
            {
                Owner owner = new Owner
                {
                    Name = textBox_OwnerName.Text,
                    Surname = textBox_OwnerSurName.Text,
                    DocumentNumber = textBox_OwnerNumberDoc.Text,
                    Email = textBox_Email.Text,
                    Telefon = textBox_Telefon.Text
                };
                SP.context.Owners.Add(owner);
                SP.context.SaveChanges();           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
    }
}

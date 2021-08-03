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
    public partial class PetTypeRegistrForm : Form
    {
        public PetTypeRegistrForm()
        {
            InitializeComponent();
        }

        bool ifClossing = false;
        private void button_Add_Click(object sender, EventArgs e)
        {
            ifClossing = true;
            try
            {
                PetType petType = new PetType
                {
                    TypeAnimal = textBox_Type.Text,
                    Breed = textBox_Breed.Text,
                    Characteristic = textBox_Char.Text,
                    DopInfo = textBox_DopInfo.Text                  
                };
                SP.context.PetTypes.Add(petType);
                SP.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void PetTypeRegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ifClossing == true && (
               textBox_Breed.Text == "" ||
               textBox_Char.Text == "" ||
               textBox_DopInfo.Text == "" ||
               textBox_Type.Text == "" ))
            {
                MessageBox.Show("Не все поля заполнены!");
                e.Cancel = true;
            }
            ifClossing = false;
        }
    }
}

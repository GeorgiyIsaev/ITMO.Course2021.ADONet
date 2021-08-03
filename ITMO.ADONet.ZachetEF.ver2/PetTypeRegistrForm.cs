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
    public partial class PetTypeRegistrForm : Form
    {
        bool ifchange = false;
        int idType;
        public PetTypeRegistrForm(bool ifchange, int idType)
        {
            InitializeComponent();
            this.ifchange = ifchange;
            this.idType = idType;
        }

        bool ifClossing = false;
        private void button_Add_Click(object sender, EventArgs e)
        {
            ifClossing = true;
            try
            {
                if (ifchange)
                {
                    ChangeTypePet();
                }
                else
                {
                    PetType petType = new PetType
                    {
                        TypeAnimal = textBox_Type.Text,
                        Breed = textBox_Breed.Text,
                        Characteristic = textBox_Char.Text,
                        DopInfo = textBox_DopInfo.Text
                    };
                    SP.context.PetTypes.Add(petType);
                }
                SP.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
        private void ChangeTypePet()
        {
            var petType = SP.context.PetTypes.Find(idType);
            if (petType == null) return;

            petType.TypeAnimal = textBox_Type.Text;
            petType.Breed = textBox_Breed.Text;
            petType.Characteristic = textBox_Char.Text;
            petType.DopInfo = textBox_DopInfo.Text;

            SP.context.Entry(petType).State = EntityState.Modified;
            SP.context.SaveChanges();
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

        private void PetTypeRegistrForm_Load(object sender, EventArgs e)
        {
            if (ifchange)
            {
                var petType = SP.context.PetTypes.Find(idType);

                textBox_Breed.Text = petType.Breed;
                textBox_Char.Text = petType.Characteristic;
                textBox_DopInfo.Text = petType.DopInfo;
                textBox_Type.Text = petType.TypeAnimal;
            }
        }
    }
}

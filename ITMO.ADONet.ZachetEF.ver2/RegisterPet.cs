using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONet.Zachet
{
    public partial class RegisterPet : Form
    {
        int idOwner = -1;
        int idPetType = -1;
        
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
            AddComboBoxTypePet();


        }

        private void AddComboBoxTypePet()
        {
            comboBox_TypePet.Items.Clear();
            comboBox_TypePet.ResetText();
            comboBox_TypePet.Items.Add("<Новый вид>");
            var query =
                from p in SP.context.PetTypes
                group p by new { FullName = p.TypeAnimal + "Порода: " + p.Breed } into g
                let count = g.Count()
                where count > 1
                select new
                {
                    g.Key.FullName,
                    Count = count
                };
            foreach (var val in query)
            {
                comboBox_TypePet.Items.Add(val.FullName);
            }
        }


     
        private void button_check_Click(object sender, EventArgs e)
        {
            if (textBox_OwnerNumberDoc.Text == String.Empty) return;
            IQueryable<Owner> selectedOwner = from user in SP.context.Owners
                                where user.DocumentNumber == textBox_OwnerNumberDoc.Text
                                select user;            

            if (selectedOwner.Count() < 1)
            {

                DialogResult result = MessageBox.Show("Добавить нового владельца",
                    "Запись не найдена!",
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    OwnerRegistrForm ownerForm = new OwnerRegistrForm(textBox_OwnerNumberDoc.Text);
                    if (ownerForm.ShowDialog() == DialogResult.OK)
                    {
                        selectedOwner = from user in SP.context.Owners
                                            where user.DocumentNumber == textBox_OwnerNumberDoc.Text
                                            select user;
                    }
                }
            }


            foreach (var val in selectedOwner)
            {
                textBox_OwnerName.Text = val.Name;
                textBox_OwnerSurName.Text = val.Surname; 
                textBox_Email.Text = val.Email;
                textBox_Telefon.Text = val.Telefon;
                idOwner = val.OwnerId;
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
            if (comboBox_TypePet.SelectedItem != null)
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
            try
            {      
                Pet pet = new Pet
                {
                    Name = textBox_OwnerName.Text,
                    DataRegistr = "",
                    OwnerId =  idOwner,
                    PetTypeId = idPetType                
                };
                SP.context.Pets.Add(pet);
                SP.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }


        }

   
        private void comboBox_TypePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TypePet.SelectedIndex == 0)
            {
                PetTypeRegistrForm ownerForm = new PetTypeRegistrForm();
                if (ownerForm.ShowDialog() == DialogResult.OK)
                {
                    AddComboBoxTypePet();  
                }
            }
            //var selectedPetType = from user in SP.context.PetTypes
            //                      where user.Breed == textBox_OwnerNumberDoc.Text
            //                      select user;
        }
    }
}

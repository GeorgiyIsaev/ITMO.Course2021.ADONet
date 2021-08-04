using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        bool ifCange;
        int idPet;


        public RegisterPet(bool ifCange, int IDPet = 0)
        {
            InitializeComponent();
            this.ifCange = ifCange;
            this.idPet = IDPet;
        }

       
        private void RegisterPet_Load(object sender, EventArgs e)
        {
            textBox_OwnerName.Enabled = false;
            textBox_OwnerSurName.Enabled = false;
            textBox_Email.Enabled = false;
            textBox_Telefon.Enabled = false;
            AddComboBoxTypePet();

            if (ifCange)
            {
                var pet = SP.context.Pets.Find(idPet);
                if (pet == null) return;
                textBox_NamePet.Text = pet.Name;
                dateTimePicker_registr.Value = pet.DataRegistr;
                comboBox_TypePet.SelectedIndex = pet.PetTypeId;

                var owner = SP.context.Owners.Find(pet.OwnerId);
                if (owner == null) return;
                textBox_OwnerNumberDoc.Text = owner.DocumentNumber;
                textBox_OwnerName.Text = owner.Name;
                textBox_OwnerSurName.Text = owner.Surname;
                textBox_Email.Text = owner.Email;
                textBox_Telefon.Text = owner.Telefon;                
            }
        }

        private void AddComboBoxTypePet()
        {
            comboBox_TypePet.Items.Clear();
            comboBox_TypePet.ResetText();
            comboBox_TypePet.Items.Add("<Новый вид>");
            var quere = from p in SP.context.PetTypes select p;
            foreach (var val in quere)
            {
                comboBox_TypePet.Items.Add(val);
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
                if (ifCange)
                {
                    DialogResult resultCange = MessageBox.Show("Проверка смены владельца этого питомца!",
                        "Вы действительно ходите изменить владельца для этого питомца?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (resultCange == DialogResult.No) return;
                }

                DialogResult result = MessageBox.Show("Добавить нового владельца",
                    "Запись об этом владельце не найдена! Желаете внести информацию о новом владельце?",
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
            if (comboBox_TypePet.SelectedItem == null) 
            { return false; }    

            return true;
        }     

        private void button_registr_Click(object sender, EventArgs e)
        {
            if (!CheckFullText())
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            try
            {
                if (ifCange)
                {
                    ChangeTypePet();
                    return;
                }              
                
                Pet pet = new Pet
                {
                    Name = textBox_NamePet.Text,
                    DataRegistr = dateTimePicker_registr.Value,
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

        private void ChangeTypePet()
        {
            var pet = SP.context.Pets.Find(idPet);
            if (pet == null) return;

            pet.Name = textBox_NamePet.Text;
                   pet.DataRegistr = dateTimePicker_registr.Value;
            pet.OwnerId = idOwner;
            pet.PetTypeId = idPetType;      

            SP.context.Entry(pet).State = EntityState.Modified;
            SP.context.SaveChanges();
        }




        private void comboBox_TypePet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TypePet.SelectedIndex == 0)
            {
                PetTypeRegistrForm ownerForm = new PetTypeRegistrForm(false, 0);
                if (ownerForm.ShowDialog() == DialogResult.OK)
                {
                    AddComboBoxTypePet();
                    comboBox_TypePet.SelectedItem = -1;
                    comboBox_TypePet.SelectedItem = null;
                }
            }
            else
            {
                idPetType = comboBox_TypePet.SelectedIndex;
            }
        }
    }
}

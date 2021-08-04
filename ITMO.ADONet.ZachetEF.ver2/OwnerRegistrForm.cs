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
    public partial class OwnerRegistrForm : Form
    {
        bool ifCange;
        int IDOwner;
        public OwnerRegistrForm(string DocumentNumber, bool ifCange = false)
        {
            InitializeComponent();
            textBox_OwnerNumberDoc.Text = DocumentNumber;
            this.ifCange = ifCange;
        }

        private void OwnerRegistrForm_Load(object sender, EventArgs e)
        {
            textBox_OwnerNumberDoc.Enabled = false;

            if (ifCange)
            {
                var selectedOwner = from user in SP.context.Owners
                                    where user.DocumentNumber == textBox_OwnerNumberDoc.Text
                                    select user;
                foreach (var val in selectedOwner)
                {
                    textBox_OwnerName.Text = val.Name;
                    textBox_OwnerSurName.Text = val.Surname;
                    textBox_Email.Text = val.Email;
                    textBox_Telefon.Text = val.Telefon;
                    IDOwner = val.OwnerId;
                }
            }
        }

        bool ifClossing = false;
        private void button_registr_Click(object sender, EventArgs e)
        {
            ifClossing = true;
            try
            {
                if (ifCange)
                {
                    ChandeOwner();
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void ChandeOwner()
        {
            var owner = SP.context.Owners.Find(IDOwner);
            if (owner == null) return;
            owner.Name = textBox_OwnerName.Text;
            owner.Surname = textBox_OwnerSurName.Text;
            owner.DocumentNumber = textBox_OwnerNumberDoc.Text;
              owner.Email = textBox_Email.Text;
              owner.Telefon = textBox_Telefon.Text;

            SP.context.Entry(owner).State = EntityState.Modified;
            SP.context.SaveChanges();
        }


        private void OwnerRegistrForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (ifClossing == true && (
                textBox_OwnerName.Text == "" ||
                textBox_OwnerSurName.Text == "" ||
                textBox_OwnerNumberDoc.Text == "" ||
                textBox_Email.Text == "" ||
                textBox_Telefon.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены!");
                e.Cancel = true;
            }
            ifClossing = false;
        }
    }
}

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

namespace ITMO.ADOnet.ZachetEF
{
    public partial class Form1 : Form
    {
        SampleContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (idDELL != -1)
            {
                ResetForm();
                return;
            }
            
            try
            {            
                Student student = new Student
                {
                    Name = this.textBoxName.Text,
                    Surname = this.textBoxSurName.Text,
                    Group = this.textBoxGroup.Text,
                    Document = this.textBoxDoc.Text,
                   
                 
                };
                context.Students.Add(student);
                context.SaveChanges();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Output();
            buttonDrop.Enabled = false;
            buttonFix.Enabled = false;
        }

        private void Output()
        {
            context = new SampleContext();
            dataGridView_tabl.DataSource = context.Students.ToList();
    
        }


        int idDELL = -1;
        private void dataGridView_tabl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Text = "Очисть поля и создать новую запись!";
            buttonDrop.Enabled = true;
            buttonFix.Enabled = true;

            if (dataGridView_tabl.CurrentRow == null) return;
            var student = dataGridView_tabl.CurrentRow.DataBoundItem as Student;
            if (student == null) return;
            idDELL = student.StudentId;

            textBoxName.Text = student.Name;
            textBoxSurName.Text = student.Surname;
            textBoxGroup.Text = student.Group;
            textBoxDoc.Text = student.Document;
        }

        private void buttonDrop_Click(object sender, EventArgs e)
        { 
            if (idDELL >=0)
            {
                var student = context.Students.Find(idDELL);

                context.Entry(student).State = EntityState.Deleted;
                context.SaveChanges();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Не выран объект для удаления!");
            }
        }
        private void ResetForm()
        {
            idDELL = -1;
            buttonAdd.Text = "Добавить";
            buttonDrop.Enabled = false;
            buttonFix.Enabled = false;
            textBoxName.Text = String.Empty;
            textBoxSurName.Text = String.Empty;
            textBoxGroup.Text = String.Empty;
            textBoxDoc.Text = String.Empty;
            Output();
        }


        private void buttonFix_Click(object sender, EventArgs e)
        {
            var student = context.Students.Find(idDELL);
            if (student == null) return;

            student.Name = this.textBoxName.Text;
            student.Surname = this.textBoxSurName.Text;
            student.Group = this.textBoxGroup.Text;
            student.Document = this.textBoxDoc.Text;

            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();

            ResetForm();
        }
    }
}


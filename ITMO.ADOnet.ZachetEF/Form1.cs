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
                textBoxName.Text = String.Empty;
                textBoxSurName.Text = String.Empty;
                textBoxGroup.Text = String.Empty;
                textBoxDoc.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
            Output();
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
            buttonAdd.Enabled = false;
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
                var customer = context.Students.Find(idDELL);

                context.Entry(customer).State = EntityState.Deleted;
                context.SaveChanges();
                Output();
                idDELL = -1;
                buttonAdd.Enabled = true;
                buttonDrop.Enabled = false;
                buttonFix.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не выран объект для удаления!");
            }
        }
    }
}


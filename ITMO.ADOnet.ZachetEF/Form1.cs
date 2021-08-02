using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

    }
}
}

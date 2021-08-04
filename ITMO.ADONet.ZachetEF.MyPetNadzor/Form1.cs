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
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }


        private void DataGridVievFromOwner()
        {
            var query =
                from o in SP.context.Owners
                select new
                {
                    ID = o.OwnerId,
                    o.Name,
                    o.Surname,
                    o.DocumentNumber,
                    o.Email,
                    o.Telefon,
                    countPets = (from p in SP.context.Pets
                                 where p.OwnerId == o.OwnerId
                                 select p).Count()

                };
            DataGridView_PetsList.DataSource = query.ToList();
        }
        private void DataGridVievFromPet()
        {
             var query =
               from p in SP.context.Pets
               join ow in SP.context.Owners on p.OwnerId equals ow.OwnerId
               join pt in SP.context.PetTypes on p.PetTypeId equals pt.PetTypeId
               select new
               {   
                   ID = p.PetId,
                   PetName = p.Name,
                   TypePet = pt.TypeAnimal + " (" + pt.Breed +")",
                   Owner = ow.Name + " " + ow.Surname,   
                   p.DataRegistr                  
               };
            DataGridView_PetsList.DataSource = query.ToList();
        }

        private void button_vievPet_Click(object sender, EventArgs e)
        {
            comboBox_InTabl.SelectedIndex = 0;
        }

        private void button_VievOwner_Click(object sender, EventArgs e)
        {
            comboBox_InTabl.SelectedIndex = 1;
        }

        private void button_regist_Click(object sender, EventArgs e)
        {
            RegisterPet form = new RegisterPet(false);
            form.Show();
            UpdeteDataGridView_PetsList();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            SP.context = new SampleContext();
            comboBox_InTabl.Items.Add("Информация о питомцах");
            comboBox_InTabl.Items.Add("Информация о владельцах");
            comboBox_InTabl.Items.Add("Виды животных");
            // comboBox_InTabl.Items.Add("Владельцы (SQL)");
            // comboBox_InTabl.Items.Add("Питомцы (SQL)");

        }

        private void comboBox_InTabl_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdeteDataGridView_PetsList();
        }

        private void UpdeteDataGridView_PetsList()
        {
            int val = -1;
            val = comboBox_InTabl.SelectedIndex;
            switch (val)
            {
                case 0: DataGridVievFromPet(); break;
                case 1: DataGridVievFromOwner(); break;
                case 2: DataGridView_PetsList.DataSource = SP.context.PetTypes.ToList(); break;
                case 3: DataGridView_PetsList.DataSource = SP.context.Owners.ToList(); break;
                case 4: DataGridView_PetsList.DataSource = SP.context.Pets.ToList(); break;
            }  
        }



        private void button_update_Click(object sender, EventArgs e)
        {
            UpdeteDataGridView_PetsList();
        }

        private void button_record_Click(object sender, EventArgs e)
        {        
            if (DataGridView_PetsList.CurrentRow == null) return;

      
            
            int valTabl = comboBox_InTabl.SelectedIndex;
            int currentRowTabl = DataGridView_PetsList.CurrentRow.Index;
    
            if (currentRowTabl < 0) return;

            switch (valTabl)
            {
                case 0: case 4:
                    int IDPet = Int32.Parse(DataGridView_PetsList.Rows[currentRowTabl].Cells[0].Value.ToString());
                    RegisterPet form = new RegisterPet(true, IDPet);
                    form.Show();                
                    break;
                case 1: case 3:
                    String docNumber = DataGridView_PetsList.Rows[currentRowTabl].Cells[3].Value.ToString();
                    OwnerRegistrForm ownerForm = new OwnerRegistrForm(docNumber, true);
                    if (ownerForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdeteDataGridView_PetsList();
                    }
                    break;
                case 2:
                    PetTypeRegistrForm petTypeForm = new PetTypeRegistrForm(true, currentRowTabl+1);
                    if (petTypeForm.ShowDialog() == DialogResult.OK)
                    {
                        UpdeteDataGridView_PetsList();
                    }
                    break;
              
            }
            DataGridView_PetsList.ClearSelection();
            UpdeteDataGridView_PetsList();
        }
      
    }
}

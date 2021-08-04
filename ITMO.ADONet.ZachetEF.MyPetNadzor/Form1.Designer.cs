namespace ITMO.ADONet.Zachet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_regist = new System.Windows.Forms.Button();
            this.button_vievPet = new System.Windows.Forms.Button();
            this.DataGridView_PetsList = new System.Windows.Forms.DataGridView();
            this.comboBox_InTabl = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_record = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_regist
            // 
            this.button_regist.Location = new System.Drawing.Point(423, 12);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(365, 32);
            this.button_regist.TabIndex = 0;
            this.button_regist.Text = "Регистрация питомца";
            this.button_regist.UseVisualStyleBackColor = true;
            this.button_regist.Click += new System.EventHandler(this.button_regist_Click);
            // 
            // button_vievPet
            // 
            this.button_vievPet.Location = new System.Drawing.Point(79, 12);
            this.button_vievPet.Name = "button_vievPet";
            this.button_vievPet.Size = new System.Drawing.Size(323, 32);
            this.button_vievPet.TabIndex = 1;
            this.button_vievPet.Text = "Просмотр всех питомцев";
            this.button_vievPet.UseVisualStyleBackColor = true;
            this.button_vievPet.Click += new System.EventHandler(this.button_vievPet_Click);
            // 
            // DataGridView_PetsList
            // 
            this.DataGridView_PetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_PetsList.Location = new System.Drawing.Point(12, 77);
            this.DataGridView_PetsList.Name = "DataGridView_PetsList";
            this.DataGridView_PetsList.ReadOnly = true;
            this.DataGridView_PetsList.Size = new System.Drawing.Size(776, 361);
            this.DataGridView_PetsList.TabIndex = 2;
            // 
            // comboBox_InTabl
            // 
            this.comboBox_InTabl.FormattingEnabled = true;
            this.comboBox_InTabl.Location = new System.Drawing.Point(79, 50);
            this.comboBox_InTabl.Name = "comboBox_InTabl";
            this.comboBox_InTabl.Size = new System.Drawing.Size(323, 21);
            this.comboBox_InTabl.TabIndex = 4;
            this.comboBox_InTabl.SelectedIndexChanged += new System.EventHandler(this.comboBox_InTabl_SelectedIndexChanged);
            // 
            // button_update
            // 
            this.button_update.Image = ((System.Drawing.Image)(resources.GetObject("button_update.Image")));
            this.button_update.Location = new System.Drawing.Point(12, 13);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(61, 59);
            this.button_update.TabIndex = 5;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_record
            // 
            this.button_record.Location = new System.Drawing.Point(423, 50);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(365, 22);
            this.button_record.TabIndex = 6;
            this.button_record.Text = "Редактировать запись";
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 48);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить запись";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_record);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.comboBox_InTabl);
            this.Controls.Add(this.DataGridView_PetsList);
            this.Controls.Add(this.button_vievPet);
            this.Controls.Add(this.button_regist);
            this.Name = "Form1";
            this.Text = "RosPetNadzor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_regist;
        private System.Windows.Forms.Button button_vievPet;
        private System.Windows.Forms.DataGridView DataGridView_PetsList;
        private System.Windows.Forms.ComboBox comboBox_InTabl;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
    }
}


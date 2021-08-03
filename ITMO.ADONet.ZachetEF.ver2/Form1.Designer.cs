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
            this.button_regist = new System.Windows.Forms.Button();
            this.button_vievPet = new System.Windows.Forms.Button();
            this.DataGridView_PetsList = new System.Windows.Forms.DataGridView();
            this.button_VievOwner = new System.Windows.Forms.Button();
            this.comboBox_InTabl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).BeginInit();
            this.SuspendLayout();
            // 
            // button_regist
            // 
            this.button_regist.Location = new System.Drawing.Point(409, 12);
            this.button_regist.Name = "button_regist";
            this.button_regist.Size = new System.Drawing.Size(379, 32);
            this.button_regist.TabIndex = 0;
            this.button_regist.Text = "Регистрация питомца";
            this.button_regist.UseVisualStyleBackColor = true;
            this.button_regist.Click += new System.EventHandler(this.button_regist_Click);
            // 
            // button_vievPet
            // 
            this.button_vievPet.Location = new System.Drawing.Point(12, 12);
            this.button_vievPet.Name = "button_vievPet";
            this.button_vievPet.Size = new System.Drawing.Size(391, 32);
            this.button_vievPet.TabIndex = 1;
            this.button_vievPet.Text = "Просмотр всех питомцев";
            this.button_vievPet.UseVisualStyleBackColor = true;
            this.button_vievPet.Click += new System.EventHandler(this.button_vievPet_Click);
            // 
            // DataGridView_PetsList
            // 
            this.DataGridView_PetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_PetsList.Location = new System.Drawing.Point(12, 91);
            this.DataGridView_PetsList.Name = "DataGridView_PetsList";
            this.DataGridView_PetsList.Size = new System.Drawing.Size(776, 347);
            this.DataGridView_PetsList.TabIndex = 2;
            // 
            // button_VievOwner
            // 
            this.button_VievOwner.Location = new System.Drawing.Point(12, 53);
            this.button_VievOwner.Name = "button_VievOwner";
            this.button_VievOwner.Size = new System.Drawing.Size(391, 32);
            this.button_VievOwner.TabIndex = 3;
            this.button_VievOwner.Text = "Просмотр всех владельцев";
            this.button_VievOwner.UseVisualStyleBackColor = true;
            this.button_VievOwner.Click += new System.EventHandler(this.button_VievOwner_Click);
            // 
            // comboBox_InTabl
            // 
            this.comboBox_InTabl.FormattingEnabled = true;
            this.comboBox_InTabl.Location = new System.Drawing.Point(409, 53);
            this.comboBox_InTabl.Name = "comboBox_InTabl";
            this.comboBox_InTabl.Size = new System.Drawing.Size(241, 21);
            this.comboBox_InTabl.TabIndex = 4;
            this.comboBox_InTabl.SelectedIndexChanged += new System.EventHandler(this.comboBox_InTabl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_InTabl);
            this.Controls.Add(this.button_VievOwner);
            this.Controls.Add(this.DataGridView_PetsList);
            this.Controls.Add(this.button_vievPet);
            this.Controls.Add(this.button_regist);
            this.Name = "Form1";
            this.Text = "RosPetNadzor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_regist;
        private System.Windows.Forms.Button button_vievPet;
        private System.Windows.Forms.DataGridView DataGridView_PetsList;
        private System.Windows.Forms.Button button_VievOwner;
        private System.Windows.Forms.ComboBox comboBox_InTabl;
    }
}


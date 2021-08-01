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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DataGridView_PetsList = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(379, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Регистрация питомца";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Просмотр всех питомцев";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DataGridView_PetsList
            // 
            this.DataGridView_PetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_PetsList.Location = new System.Drawing.Point(12, 91);
            this.DataGridView_PetsList.Name = "DataGridView_PetsList";
            this.DataGridView_PetsList.Size = new System.Drawing.Size(776, 347);
            this.DataGridView_PetsList.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(391, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Просмотр всех владельцев";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DataGridView_PetsList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "RosPetNadzor";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_PetsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DataGridView_PetsList;
        private System.Windows.Forms.Button button3;
    }
}


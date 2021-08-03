namespace ITMO.ADONet.Zachet
{
    partial class PetTypeRegistrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_DopInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Char = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Breed = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_DopInfo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Char);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_Breed);
            this.groupBox2.Controls.Add(this.textBox_Type);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 196);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вид животного";
            // 
            // textBox_DopInfo
            // 
            this.textBox_DopInfo.Location = new System.Drawing.Point(127, 139);
            this.textBox_DopInfo.Multiline = true;
            this.textBox_DopInfo.Name = "textBox_DopInfo";
            this.textBox_DopInfo.Size = new System.Drawing.Size(388, 46);
            this.textBox_DopInfo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дополнительно";
            // 
            // textBox_Char
            // 
            this.textBox_Char.Location = new System.Drawing.Point(127, 87);
            this.textBox_Char.Multiline = true;
            this.textBox_Char.Name = "textBox_Char";
            this.textBox_Char.Size = new System.Drawing.Size(388, 46);
            this.textBox_Char.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Характеристика";
            // 
            // textBox_Breed
            // 
            this.textBox_Breed.Location = new System.Drawing.Point(127, 53);
            this.textBox_Breed.Name = "textBox_Breed";
            this.textBox_Breed.Size = new System.Drawing.Size(176, 20);
            this.textBox_Breed.TabIndex = 9;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(127, 26);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(176, 20);
            this.textBox_Type.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Порода:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Вид питомца:";
            // 
            // button_Add
            // 
            this.button_Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Add.Location = new System.Drawing.Point(13, 215);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(529, 29);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // PetTypeRegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 249);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox2);
            this.Name = "PetTypeRegistrForm";
            this.Text = "Регистрация вида животного";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PetTypeRegistrForm_FormClosing);
            this.Load += new System.EventHandler(this.PetTypeRegistrForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Breed;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.TextBox textBox_DopInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Char;
        private System.Windows.Forms.Button button_Add;
    }
}
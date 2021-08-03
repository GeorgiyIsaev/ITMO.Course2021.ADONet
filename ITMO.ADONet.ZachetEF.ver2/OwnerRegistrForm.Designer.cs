namespace ITMO.ADONet.Zachet
{
    partial class OwnerRegistrForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_registr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_OwnerSurName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_OwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_OwnerNumberDoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Telefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_OwnerSurName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_OwnerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_OwnerNumberDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Владелец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon";
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Location = new System.Drawing.Point(119, 127);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(205, 20);
            this.textBox_Telefon.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(119, 101);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(205, 20);
            this.textBox_Email.TabIndex = 7;
            // 
            // button_registr
            // 
            this.button_registr.Location = new System.Drawing.Point(30, 176);
            this.button_registr.Name = "button_registr";
            this.button_registr.Size = new System.Drawing.Size(328, 23);
            this.button_registr.TabIndex = 6;
            this.button_registr.Text = "Зарегестрировать";
            this.button_registr.UseVisualStyleBackColor = true;
            this.button_registr.Click += new System.EventHandler(this.button_registr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // textBox_OwnerSurName
            // 
            this.textBox_OwnerSurName.Location = new System.Drawing.Point(119, 75);
            this.textBox_OwnerSurName.Name = "textBox_OwnerSurName";
            this.textBox_OwnerSurName.Size = new System.Drawing.Size(205, 20);
            this.textBox_OwnerSurName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // textBox_OwnerName
            // 
            this.textBox_OwnerName.Location = new System.Drawing.Point(119, 49);
            this.textBox_OwnerName.Name = "textBox_OwnerName";
            this.textBox_OwnerName.Size = new System.Drawing.Size(205, 20);
            this.textBox_OwnerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер документа";
            // 
            // textBox_OwnerNumberDoc
            // 
            this.textBox_OwnerNumberDoc.Location = new System.Drawing.Point(119, 23);
            this.textBox_OwnerNumberDoc.Name = "textBox_OwnerNumberDoc";
            this.textBox_OwnerNumberDoc.Size = new System.Drawing.Size(205, 20);
            this.textBox_OwnerNumberDoc.TabIndex = 0;
            // 
            // OwnerRegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_registr);
            this.Name = "OwnerRegistrForm";
            this.Text = "Регистрация владельца";
            this.Load += new System.EventHandler(this.OwnerRegistrForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_registr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_OwnerSurName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_OwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_OwnerNumberDoc;
    }
}
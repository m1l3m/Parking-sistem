namespace Parking_Servis
{
    partial class Rezervacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezervacija));
            this.textBox_RegistarskeOznake = new System.Windows.Forms.TextBox();
            this.textBox_BrojDokumenta = new System.Windows.Forms.TextBox();
            this.textBox_VrijemeDolaska = new System.Windows.Forms.TextBox();
            this.lbl_RegistarskeOznake = new System.Windows.Forms.Label();
            this.lbl_BrojDokumenta = new System.Windows.Forms.Label();
            this.lbl_Tip_Vozila = new System.Windows.Forms.Label();
            this.lbl_Vrijeme = new System.Windows.Forms.Label();
            this.lbl_TrenutnoVrijeme = new System.Windows.Forms.Label();
            this.button_Rezervisi = new System.Windows.Forms.Button();
            this.checkBox_TrenutnoVrijeme = new System.Windows.Forms.CheckBox();
            this.comboBox_Tip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_RegistarskeOznake
            // 
            this.textBox_RegistarskeOznake.Location = new System.Drawing.Point(131, 25);
            this.textBox_RegistarskeOznake.Name = "textBox_RegistarskeOznake";
            this.textBox_RegistarskeOznake.Size = new System.Drawing.Size(161, 20);
            this.textBox_RegistarskeOznake.TabIndex = 0;
            // 
            // textBox_BrojDokumenta
            // 
            this.textBox_BrojDokumenta.Location = new System.Drawing.Point(131, 51);
            this.textBox_BrojDokumenta.Name = "textBox_BrojDokumenta";
            this.textBox_BrojDokumenta.Size = new System.Drawing.Size(161, 20);
            this.textBox_BrojDokumenta.TabIndex = 1;
            // 
            // textBox_VrijemeDolaska
            // 
            this.textBox_VrijemeDolaska.Location = new System.Drawing.Point(131, 136);
            this.textBox_VrijemeDolaska.Name = "textBox_VrijemeDolaska";
            this.textBox_VrijemeDolaska.Size = new System.Drawing.Size(161, 20);
            this.textBox_VrijemeDolaska.TabIndex = 2;
            // 
            // lbl_RegistarskeOznake
            // 
            this.lbl_RegistarskeOznake.AutoSize = true;
            this.lbl_RegistarskeOznake.Location = new System.Drawing.Point(10, 28);
            this.lbl_RegistarskeOznake.Name = "lbl_RegistarskeOznake";
            this.lbl_RegistarskeOznake.Size = new System.Drawing.Size(104, 13);
            this.lbl_RegistarskeOznake.TabIndex = 3;
            this.lbl_RegistarskeOznake.Text = "Registarske oznake:";
            // 
            // lbl_BrojDokumenta
            // 
            this.lbl_BrojDokumenta.AutoSize = true;
            this.lbl_BrojDokumenta.Location = new System.Drawing.Point(30, 54);
            this.lbl_BrojDokumenta.Name = "lbl_BrojDokumenta";
            this.lbl_BrojDokumenta.Size = new System.Drawing.Size(84, 13);
            this.lbl_BrojDokumenta.TabIndex = 4;
            this.lbl_BrojDokumenta.Text = "Broj dokumenta:";
            // 
            // lbl_Tip_Vozila
            // 
            this.lbl_Tip_Vozila.AutoSize = true;
            this.lbl_Tip_Vozila.Location = new System.Drawing.Point(59, 80);
            this.lbl_Tip_Vozila.Name = "lbl_Tip_Vozila";
            this.lbl_Tip_Vozila.Size = new System.Drawing.Size(55, 13);
            this.lbl_Tip_Vozila.TabIndex = 5;
            this.lbl_Tip_Vozila.Text = "Tip vozila:";
            // 
            // lbl_Vrijeme
            // 
            this.lbl_Vrijeme.AutoSize = true;
            this.lbl_Vrijeme.Location = new System.Drawing.Point(30, 116);
            this.lbl_Vrijeme.Name = "lbl_Vrijeme";
            this.lbl_Vrijeme.Size = new System.Drawing.Size(84, 13);
            this.lbl_Vrijeme.TabIndex = 6;
            this.lbl_Vrijeme.Text = "Vrijeme dolaska:";
            // 
            // lbl_TrenutnoVrijeme
            // 
            this.lbl_TrenutnoVrijeme.AutoSize = true;
            this.lbl_TrenutnoVrijeme.Location = new System.Drawing.Point(148, 116);
            this.lbl_TrenutnoVrijeme.Name = "lbl_TrenutnoVrijeme";
            this.lbl_TrenutnoVrijeme.Size = new System.Drawing.Size(68, 13);
            this.lbl_TrenutnoVrijeme.TabIndex = 7;
            this.lbl_TrenutnoVrijeme.Text = "Upravo sada";
            // 
            // button_Rezervisi
            // 
            this.button_Rezervisi.Location = new System.Drawing.Point(115, 186);
            this.button_Rezervisi.Name = "button_Rezervisi";
            this.button_Rezervisi.Size = new System.Drawing.Size(75, 23);
            this.button_Rezervisi.TabIndex = 8;
            this.button_Rezervisi.Text = "Rezerviši";
            this.button_Rezervisi.UseVisualStyleBackColor = true;
            this.button_Rezervisi.Click += new System.EventHandler(this.button_Rezervisi_Click);
            // 
            // checkBox_TrenutnoVrijeme
            // 
            this.checkBox_TrenutnoVrijeme.AutoSize = true;
            this.checkBox_TrenutnoVrijeme.Location = new System.Drawing.Point(222, 116);
            this.checkBox_TrenutnoVrijeme.Name = "checkBox_TrenutnoVrijeme";
            this.checkBox_TrenutnoVrijeme.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TrenutnoVrijeme.TabIndex = 9;
            this.checkBox_TrenutnoVrijeme.UseVisualStyleBackColor = true;
            this.checkBox_TrenutnoVrijeme.CheckedChanged += new System.EventHandler(this.checkBox_TrenutnoVrijeme_CheckedChanged);
            // 
            // comboBox_Tip
            // 
            this.comboBox_Tip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tip.FormattingEnabled = true;
            this.comboBox_Tip.Items.AddRange(new object[] {
            "Automobil",
            "Kamion",
            "Kombi",
            "Motocikl"});
            this.comboBox_Tip.Location = new System.Drawing.Point(131, 77);
            this.comboBox_Tip.Name = "comboBox_Tip";
            this.comboBox_Tip.Size = new System.Drawing.Size(161, 21);
            this.comboBox_Tip.TabIndex = 10;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.comboBox_Tip);
            this.Controls.Add(this.checkBox_TrenutnoVrijeme);
            this.Controls.Add(this.button_Rezervisi);
            this.Controls.Add(this.lbl_TrenutnoVrijeme);
            this.Controls.Add(this.lbl_Vrijeme);
            this.Controls.Add(this.lbl_Tip_Vozila);
            this.Controls.Add(this.lbl_BrojDokumenta);
            this.Controls.Add(this.lbl_RegistarskeOznake);
            this.Controls.Add(this.textBox_VrijemeDolaska);
            this.Controls.Add(this.textBox_BrojDokumenta);
            this.Controls.Add(this.textBox_RegistarskeOznake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rezervacija_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_RegistarskeOznake;
        private System.Windows.Forms.TextBox textBox_BrojDokumenta;
        private System.Windows.Forms.TextBox textBox_VrijemeDolaska;
        private System.Windows.Forms.Label lbl_RegistarskeOznake;
        private System.Windows.Forms.Label lbl_BrojDokumenta;
        private System.Windows.Forms.Label lbl_Tip_Vozila;
        private System.Windows.Forms.Label lbl_Vrijeme;
        private System.Windows.Forms.Label lbl_TrenutnoVrijeme;
        private System.Windows.Forms.Button button_Rezervisi;
        private System.Windows.Forms.CheckBox checkBox_TrenutnoVrijeme;
        private System.Windows.Forms.ComboBox comboBox_Tip;
    }
}
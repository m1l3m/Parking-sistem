using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parking_Servis
{
    
    
    public partial class Rezervacija : Form
    {
        
        public Rezervacija()
        {
            InitializeComponent();
        }
        
        
        private void checkBox_TrenutnoVrijeme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TrenutnoVrijeme.Checked == true)
            {
                textBox_VrijemeDolaska.Text = DateTime.Now.ToString("HH:mm:ss");
                textBox_VrijemeDolaska.Enabled = false;
            }
            else
            {
                textBox_VrijemeDolaska.Text = "";
                textBox_VrijemeDolaska.Enabled = true;
            }
        }
     
        
        private void button_Rezervisi_Click(object sender, EventArgs e)
        {

            if (textBox_BrojDokumenta.Text != "" && textBox_RegistarskeOznake.Text != "" && textBox_VrijemeDolaska.Text != "" && comboBox_Tip.Text != "")
            {

                try
                {
                    Properties.Settings.Default.vrijeme = DateTime.Parse(textBox_VrijemeDolaska.Text);
                    Properties.Settings.Default.zauzet = true;
                    Properties.Settings.Default.aktivnost = "M" + Properties.Settings.Default.mjesto + "- Dolazak  " + Properties.Settings.Default.vrijeme + "\nRegistarska oznaka: " + textBox_RegistarskeOznake.Text + "\nTip: " + comboBox_Tip.Text + "\n\n";
                    Properties.Settings.Default.Save();
                    Console.WriteLine(Properties.Settings.Default.aktivnost);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Unesite vrijeme u formatu HH:MM:SS", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

            else
            {
                Properties.Settings.Default.zauzet = false;
                MessageBox.Show("Popunite sva polja", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Rezervacija_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

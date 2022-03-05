using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parking_Servis
{
    public partial class main_Parking : Form
    {
        public main_Parking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            statuslbl_VrijemeDatum.Text = DateTime.Now.ToString("H:mm  d.M.yyyy.");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            statuslbl_VrijemeDatum.Text = DateTime.Now.ToString("H:mm  d.M.yyyy.");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eksportAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox_Aktivnost.Text != "")
            {
                SaveFileDialog sacuvaj = new SaveFileDialog();
                sacuvaj.Filter = "Tekstualni fajl (*.txt)|*.txt";
                sacuvaj.ShowDialog();
                if (sacuvaj.FileName != "")
                    File.WriteAllText(sacuvaj.FileName, richTextBox_Aktivnost.Text);
            }
            else
                MessageBox.Show("Nema aktivnosti!","Pažnja",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
        private void rezervišiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mjesto = int.Parse(contextMenuStrip1.SourceControl.Text);
            Rezervacija nova = new Rezervacija();
            nova.Text = "M" + Properties.Settings.Default.mjesto + " - " + "Parking rezervacija";
            nova.Show();
            nova.FormClosing += Rezervacija_FormClosing;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
            if (contextMenuStrip1.SourceControl.BackColor == Color.Green)
            {
                
                rezervišiToolStripMenuItem.Enabled = true;
                naplatiToolStripMenuItem.Enabled = false;
            }
            else
            {
                rezervišiToolStripMenuItem.Enabled = false;
                naplatiToolStripMenuItem.Enabled = true;
 
            }
        }

        private void naplatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Aktivnost.Text += "M"+contextMenuStrip1.SourceControl.Text+" Odlazak "+DateTime.Now+"\n\n";
            contextMenuStrip1.SourceControl.BackColor = Color.Green;
            Properties.Settings.Default.broj_slobodnih++;
            textBox_BrojSlobodnih.Text = Properties.Settings.Default.broj_slobodnih.ToString();
        }

        private void textBox_Aktivnost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Rezervacija_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.zauzet == true)
            {
                contextMenuStrip1.SourceControl.BackColor = Color.Red;
                richTextBox_Aktivnost.Text += Properties.Settings.Default.aktivnost;
                Properties.Settings.Default.broj_slobodnih = Convert.ToInt16(textBox_BrojSlobodnih.Text)-1;
                textBox_BrojSlobodnih.Text = Properties.Settings.Default.broj_slobodnih.ToString();
            }

            
        }

        private void main_Parking_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Control kontrola in this.Controls )
                if (kontrola is Button)
                {
                    
                }
            Properties.Settings.Default.izvjestaj = richTextBox_Aktivnost.Text;
            Properties.Settings.Default.Save();
        }


    }
}

namespace Parking_Servis
{
    partial class main_Parking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_Parking));
            this.lbl_Brojslobodnih = new System.Windows.Forms.Label();
            this.lbl_Aktivnosti = new System.Windows.Forms.Label();
            this.textBox_BrojSlobodnih = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.appToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportAktivnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl_VrijemeDatum = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button13 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.naplatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox_Aktivnost = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Brojslobodnih
            // 
            this.lbl_Brojslobodnih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Brojslobodnih.AutoSize = true;
            this.lbl_Brojslobodnih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brojslobodnih.Location = new System.Drawing.Point(485, 30);
            this.lbl_Brojslobodnih.Name = "lbl_Brojslobodnih";
            this.lbl_Brojslobodnih.Size = new System.Drawing.Size(242, 26);
            this.lbl_Brojslobodnih.TabIndex = 15;
            this.lbl_Brojslobodnih.Text = "Broj slobodnih mjesta";
            // 
            // lbl_Aktivnosti
            // 
            this.lbl_Aktivnosti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Aktivnosti.AutoSize = true;
            this.lbl_Aktivnosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aktivnosti.Location = new System.Drawing.Point(557, 115);
            this.lbl_Aktivnosti.Name = "lbl_Aktivnosti";
            this.lbl_Aktivnosti.Size = new System.Drawing.Size(116, 26);
            this.lbl_Aktivnosti.TabIndex = 16;
            this.lbl_Aktivnosti.Text = "Aktivnosti";
            // 
            // textBox_BrojSlobodnih
            // 
            this.textBox_BrojSlobodnih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_BrojSlobodnih.Enabled = false;
            this.textBox_BrojSlobodnih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BrojSlobodnih.Location = new System.Drawing.Point(565, 57);
            this.textBox_BrojSlobodnih.Multiline = true;
            this.textBox_BrojSlobodnih.Name = "textBox_BrojSlobodnih";
            this.textBox_BrojSlobodnih.Size = new System.Drawing.Size(100, 36);
            this.textBox_BrojSlobodnih.TabIndex = 18;
            this.textBox_BrojSlobodnih.Text = "14";
            this.textBox_BrojSlobodnih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // appToolStripMenuItem
            // 
            this.appToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eksportAktivnostiToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazToolStripMenuItem});
            this.appToolStripMenuItem.Name = "appToolStripMenuItem";
            this.appToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.appToolStripMenuItem.Text = "App";
            // 
            // eksportAktivnostiToolStripMenuItem
            // 
            this.eksportAktivnostiToolStripMenuItem.Name = "eksportAktivnostiToolStripMenuItem";
            this.eksportAktivnostiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.eksportAktivnostiToolStripMenuItem.Text = "Eksport aktivnosti";
            this.eksportAktivnostiToolStripMenuItem.Click += new System.EventHandler(this.eksportAktivnostiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl_VrijemeDatum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl_VrijemeDatum
            // 
            this.statuslbl_VrijemeDatum.Name = "statuslbl_VrijemeDatum";
            this.statuslbl_VrijemeDatum.Size = new System.Drawing.Size(90, 17);
            this.statuslbl_VrijemeDatum.Text = "vrijeme i datum";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button13.BackColor = System.Drawing.Color.Green;
            this.button13.ContextMenuStrip = this.contextMenuStrip1;
            this.button13.Location = new System.Drawing.Point(312, 212);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(54, 102);
            this.button13.TabIndex = 12;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervišiToolStripMenuItem,
            this.toolStripSeparator2,
            this.naplatiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // rezervišiToolStripMenuItem
            // 
            this.rezervišiToolStripMenuItem.Name = "rezervišiToolStripMenuItem";
            this.rezervišiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rezervišiToolStripMenuItem.Text = "Rezerviši";
            this.rezervišiToolStripMenuItem.Click += new System.EventHandler(this.rezervišiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // naplatiToolStripMenuItem
            // 
            this.naplatiToolStripMenuItem.Name = "naplatiToolStripMenuItem";
            this.naplatiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.naplatiToolStripMenuItem.Text = "Naplati";
            this.naplatiToolStripMenuItem.Click += new System.EventHandler(this.naplatiToolStripMenuItem_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button14.BackColor = System.Drawing.Color.Green;
            this.button14.ContextMenuStrip = this.contextMenuStrip1;
            this.button14.Location = new System.Drawing.Point(372, 212);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 102);
            this.button14.TabIndex = 13;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button12.BackColor = System.Drawing.Color.Green;
            this.button12.ContextMenuStrip = this.contextMenuStrip1;
            this.button12.Location = new System.Drawing.Point(252, 212);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 102);
            this.button12.TabIndex = 11;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.ContextMenuStrip = this.contextMenuStrip1;
            this.button11.Location = new System.Drawing.Point(192, 212);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 102);
            this.button11.TabIndex = 10;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.ContextMenuStrip = this.contextMenuStrip1;
            this.button10.Location = new System.Drawing.Point(132, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 102);
            this.button10.TabIndex = 9;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button8.BackColor = System.Drawing.Color.Green;
            this.button8.ContextMenuStrip = this.contextMenuStrip1;
            this.button8.Location = new System.Drawing.Point(12, 212);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 102);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button9.BackColor = System.Drawing.Color.Green;
            this.button9.ContextMenuStrip = this.contextMenuStrip1;
            this.button9.Location = new System.Drawing.Point(72, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 102);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.ContextMenuStrip = this.contextMenuStrip1;
            this.button7.Location = new System.Drawing.Point(372, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 102);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.ContextMenuStrip = this.contextMenuStrip1;
            this.button6.Location = new System.Drawing.Point(312, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 102);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.ContextMenuStrip = this.contextMenuStrip1;
            this.button5.Location = new System.Drawing.Point(252, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 102);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.ContextMenuStrip = this.contextMenuStrip1;
            this.button4.Location = new System.Drawing.Point(192, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 102);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.ContextMenuStrip = this.contextMenuStrip1;
            this.button3.Location = new System.Drawing.Point(132, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ContextMenuStrip = this.contextMenuStrip1;
            this.button2.Location = new System.Drawing.Point(72, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 102);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // richTextBox_Aktivnost
            // 
            this.richTextBox_Aktivnost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Aktivnost.Location = new System.Drawing.Point(490, 162);
            this.richTextBox_Aktivnost.Name = "richTextBox_Aktivnost";
            this.richTextBox_Aktivnost.ReadOnly = true;
            this.richTextBox_Aktivnost.Size = new System.Drawing.Size(237, 213);
            this.richTextBox_Aktivnost.TabIndex = 21;
            this.richTextBox_Aktivnost.Text = "";
            // 
            // main_Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 411);
            this.Controls.Add(this.richTextBox_Aktivnost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_BrojSlobodnih);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lbl_Aktivnosti);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lbl_Brojslobodnih);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(755, 450);
            this.Name = "main_Parking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Service - 2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_Parking_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Brojslobodnih;
        private System.Windows.Forms.Label lbl_Aktivnosti;
        private System.Windows.Forms.TextBox textBox_BrojSlobodnih;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem appToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl_VrijemeDatum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem eksportAktivnostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem naplatiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_Aktivnost;
    }
}


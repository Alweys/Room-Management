namespace Room_Management
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Rezervacije = new System.Windows.Forms.ListBox();
            this.label_Rezervacije = new System.Windows.Forms.Label();
            this.monthCalendar_Datum = new System.Windows.Forms.MonthCalendar();
            this.panel_NovaRezervacija = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Kraj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Pocetak = new System.Windows.Forms.ComboBox();
            this.comboBox_Prostorije2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DodajRezervaciju = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Prostorija = new System.Windows.Forms.Label();
            this.comboBox_Prostorije = new System.Windows.Forms.ComboBox();
            this.comboBox_Ponavljanja = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_NovaRezervacija.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.urediKorisnikeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // listBox_Rezervacije
            // 
            this.listBox_Rezervacije.FormattingEnabled = true;
            this.listBox_Rezervacije.ItemHeight = 14;
            this.listBox_Rezervacije.Location = new System.Drawing.Point(14, 278);
            this.listBox_Rezervacije.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox_Rezervacije.Name = "listBox_Rezervacije";
            this.listBox_Rezervacije.Size = new System.Drawing.Size(905, 144);
            this.listBox_Rezervacije.TabIndex = 2;
            this.listBox_Rezervacije.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_Rezervacije_MouseUp);
            // 
            // label_Rezervacije
            // 
            this.label_Rezervacije.AutoSize = true;
            this.label_Rezervacije.Location = new System.Drawing.Point(14, 261);
            this.label_Rezervacije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Rezervacije.Name = "label_Rezervacije";
            this.label_Rezervacije.Size = new System.Drawing.Size(98, 14);
            this.label_Rezervacije.TabIndex = 3;
            this.label_Rezervacije.Text = "label_Rezervacije";
            // 
            // monthCalendar_Datum
            // 
            this.monthCalendar_Datum.Location = new System.Drawing.Point(18, 36);
            this.monthCalendar_Datum.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendar_Datum.MaxSelectionCount = 1;
            this.monthCalendar_Datum.Name = "monthCalendar_Datum";
            this.monthCalendar_Datum.TabIndex = 4;
            this.monthCalendar_Datum.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_Datum_DateChanged);
            // 
            // panel_NovaRezervacija
            // 
            this.panel_NovaRezervacija.Controls.Add(this.label5);
            this.panel_NovaRezervacija.Controls.Add(this.label4);
            this.panel_NovaRezervacija.Controls.Add(this.comboBox_Ponavljanja);
            this.panel_NovaRezervacija.Controls.Add(this.comboBox_Kraj);
            this.panel_NovaRezervacija.Controls.Add(this.label2);
            this.panel_NovaRezervacija.Controls.Add(this.comboBox_Pocetak);
            this.panel_NovaRezervacija.Controls.Add(this.comboBox_Prostorije2);
            this.panel_NovaRezervacija.Controls.Add(this.label3);
            this.panel_NovaRezervacija.Controls.Add(this.label1);
            this.panel_NovaRezervacija.Controls.Add(this.button_DodajRezervaciju);
            this.panel_NovaRezervacija.Enabled = false;
            this.panel_NovaRezervacija.Location = new System.Drawing.Point(311, 36);
            this.panel_NovaRezervacija.Name = "panel_NovaRezervacija";
            this.panel_NovaRezervacija.Size = new System.Drawing.Size(608, 239);
            this.panel_NovaRezervacija.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kraj:";
            // 
            // comboBox_Kraj
            // 
            this.comboBox_Kraj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kraj.FormattingEnabled = true;
            this.comboBox_Kraj.Location = new System.Drawing.Point(85, 92);
            this.comboBox_Kraj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Kraj.Name = "comboBox_Kraj";
            this.comboBox_Kraj.Size = new System.Drawing.Size(140, 22);
            this.comboBox_Kraj.TabIndex = 13;
            this.comboBox_Kraj.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kraj_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pocetak:";
            // 
            // comboBox_Pocetak
            // 
            this.comboBox_Pocetak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Pocetak.FormattingEnabled = true;
            this.comboBox_Pocetak.Location = new System.Drawing.Point(85, 60);
            this.comboBox_Pocetak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Pocetak.Name = "comboBox_Pocetak";
            this.comboBox_Pocetak.Size = new System.Drawing.Size(140, 22);
            this.comboBox_Pocetak.TabIndex = 13;
            this.comboBox_Pocetak.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pocetak_SelectedIndexChanged);
            // 
            // comboBox_Prostorije2
            // 
            this.comboBox_Prostorije2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Prostorije2.FormattingEnabled = true;
            this.comboBox_Prostorije2.Location = new System.Drawing.Point(85, 30);
            this.comboBox_Prostorije2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Prostorije2.Name = "comboBox_Prostorije2";
            this.comboBox_Prostorije2.Size = new System.Drawing.Size(140, 22);
            this.comboBox_Prostorije2.TabIndex = 13;
            this.comboBox_Prostorije2.SelectedIndexChanged += new System.EventHandler(this.comboBox_Prostorije2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prostorija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nova Rezervacija";
            // 
            // button_DodajRezervaciju
            // 
            this.button_DodajRezervaciju.Location = new System.Drawing.Point(9, 151);
            this.button_DodajRezervaciju.Name = "button_DodajRezervaciju";
            this.button_DodajRezervaciju.Size = new System.Drawing.Size(216, 59);
            this.button_DodajRezervaciju.TabIndex = 8;
            this.button_DodajRezervaciju.Text = "Dodaj Rezervaciju";
            this.button_DodajRezervaciju.UseVisualStyleBackColor = true;
            this.button_DodajRezervaciju.Click += new System.EventHandler(this.button_DodajRezervaciju_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrišiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Enabled = false;
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // label_Prostorija
            // 
            this.label_Prostorija.AutoSize = true;
            this.label_Prostorija.Location = new System.Drawing.Point(14, 232);
            this.label_Prostorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Prostorija.Name = "label_Prostorija";
            this.label_Prostorija.Size = new System.Drawing.Size(61, 14);
            this.label_Prostorija.TabIndex = 5;
            this.label_Prostorija.Text = "Prostorija:";
            // 
            // comboBox_Prostorije
            // 
            this.comboBox_Prostorije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Prostorije.FormattingEnabled = true;
            this.comboBox_Prostorije.Location = new System.Drawing.Point(83, 228);
            this.comboBox_Prostorije.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Prostorije.Name = "comboBox_Prostorije";
            this.comboBox_Prostorije.Size = new System.Drawing.Size(140, 22);
            this.comboBox_Prostorije.TabIndex = 6;
            this.comboBox_Prostorije.SelectedIndexChanged += new System.EventHandler(this.comboBox_Prostorije_SelectedIndexChanged);
            // 
            // comboBox_Ponavljanja
            // 
            this.comboBox_Ponavljanja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ponavljanja.FormattingEnabled = true;
            this.comboBox_Ponavljanja.Location = new System.Drawing.Point(85, 123);
            this.comboBox_Ponavljanja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Ponavljanja.Name = "comboBox_Ponavljanja";
            this.comboBox_Ponavljanja.Size = new System.Drawing.Size(140, 22);
            this.comboBox_Ponavljanja.TabIndex = 13;
            this.comboBox_Ponavljanja.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kraj_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ponavljanje:";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Enabled = false;
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // urediKorisnikeToolStripMenuItem
            // 
            this.urediKorisnikeToolStripMenuItem.Enabled = false;
            this.urediKorisnikeToolStripMenuItem.Name = "urediKorisnikeToolStripMenuItem";
            this.urediKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urediKorisnikeToolStripMenuItem.Text = "Uredi korisnike";
            this.urediKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.urediKorisnikeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.panel_NovaRezervacija);
            this.Controls.Add(this.comboBox_Prostorije);
            this.Controls.Add(this.label_Prostorija);
            this.Controls.Add(this.monthCalendar_Datum);
            this.Controls.Add(this.label_Rezervacije);
            this.Controls.Add(this.listBox_Rezervacije);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_NovaRezervacija.ResumeLayout(false);
            this.panel_NovaRezervacija.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_Rezervacije;
        private System.Windows.Forms.Label label_Rezervacije;
        private System.Windows.Forms.MonthCalendar monthCalendar_Datum;
        private System.Windows.Forms.Panel panel_NovaRezervacija;
        private System.Windows.Forms.Button button_DodajRezervaciju;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Prostorija;
        private System.Windows.Forms.ComboBox comboBox_Prostorije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Pocetak;
        private System.Windows.Forms.ComboBox comboBox_Prostorije2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Kraj;
        private System.Windows.Forms.ComboBox comboBox_Ponavljanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediKorisnikeToolStripMenuItem;
    }
}


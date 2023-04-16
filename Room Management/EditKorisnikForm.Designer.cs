namespace Room_Management
{
    partial class EditKorisnikForm
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
            this.comboBox_Korisnici = new System.Windows.Forms.ComboBox();
            this.button_Obrisi = new System.Windows.Forms.Button();
            this.button_Odustani = new System.Windows.Forms.Button();
            this.button_Uredi = new System.Windows.Forms.Button();
            this.checkedListBox_Prava = new System.Windows.Forms.CheckedListBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Korisnici
            // 
            this.comboBox_Korisnici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Korisnici.FormattingEnabled = true;
            this.comboBox_Korisnici.Location = new System.Drawing.Point(86, 36);
            this.comboBox_Korisnici.Name = "comboBox_Korisnici";
            this.comboBox_Korisnici.Size = new System.Drawing.Size(167, 22);
            this.comboBox_Korisnici.TabIndex = 44;
            this.comboBox_Korisnici.SelectedIndexChanged += new System.EventHandler(this.comboBox_Korisnici_SelectedIndexChanged);
            // 
            // button_Obrisi
            // 
            this.button_Obrisi.Enabled = false;
            this.button_Obrisi.ForeColor = System.Drawing.Color.Red;
            this.button_Obrisi.Location = new System.Drawing.Point(18, 246);
            this.button_Obrisi.Name = "button_Obrisi";
            this.button_Obrisi.Size = new System.Drawing.Size(75, 23);
            this.button_Obrisi.TabIndex = 43;
            this.button_Obrisi.Text = "Obriši";
            this.button_Obrisi.UseVisualStyleBackColor = true;
            this.button_Obrisi.Click += new System.EventHandler(this.button_Obrisi_Click);
            // 
            // button_Odustani
            // 
            this.button_Odustani.Location = new System.Drawing.Point(97, 246);
            this.button_Odustani.Name = "button_Odustani";
            this.button_Odustani.Size = new System.Drawing.Size(75, 23);
            this.button_Odustani.TabIndex = 39;
            this.button_Odustani.Text = "Odustani";
            this.button_Odustani.UseVisualStyleBackColor = true;
            this.button_Odustani.Click += new System.EventHandler(this.button_Odustani_Click);
            // 
            // button_Uredi
            // 
            this.button_Uredi.Location = new System.Drawing.Point(178, 246);
            this.button_Uredi.Name = "button_Uredi";
            this.button_Uredi.Size = new System.Drawing.Size(75, 23);
            this.button_Uredi.TabIndex = 38;
            this.button_Uredi.Text = "Uredi";
            this.button_Uredi.UseVisualStyleBackColor = true;
            this.button_Uredi.Click += new System.EventHandler(this.button_Uredi_Click);
            // 
            // checkedListBox_Prava
            // 
            this.checkedListBox_Prava.FormattingEnabled = true;
            this.checkedListBox_Prava.Location = new System.Drawing.Point(86, 92);
            this.checkedListBox_Prava.Name = "checkedListBox_Prava";
            this.checkedListBox_Prava.Size = new System.Drawing.Size(167, 140);
            this.checkedListBox_Prava.TabIndex = 37;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(86, 64);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(167, 22);
            this.textBox_FullName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Prava:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "Username:";
            // 
            // EditKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 305);
            this.Controls.Add(this.comboBox_Korisnici);
            this.Controls.Add(this.button_Obrisi);
            this.Controls.Add(this.button_Odustani);
            this.Controls.Add(this.button_Uredi);
            this.Controls.Add(this.checkedListBox_Prava);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditKorisnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uređivanje korisnika";
            this.Load += new System.EventHandler(this.EditKorisnikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Korisnici;
        private System.Windows.Forms.Button button_Obrisi;
        private System.Windows.Forms.Button button_Odustani;
        private System.Windows.Forms.Button button_Uredi;
        private System.Windows.Forms.CheckedListBox checkedListBox_Prava;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
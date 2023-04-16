namespace Room_Management
{
    partial class NoviKorisnikForm
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
            this.checkedListBox_Prava = new System.Windows.Forms.CheckedListBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Odustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_Prava
            // 
            this.checkedListBox_Prava.FormattingEnabled = true;
            this.checkedListBox_Prava.Location = new System.Drawing.Point(86, 116);
            this.checkedListBox_Prava.Name = "checkedListBox_Prava";
            this.checkedListBox_Prava.Size = new System.Drawing.Size(167, 140);
            this.checkedListBox_Prava.TabIndex = 4;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(86, 88);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(167, 22);
            this.textBox_FullName.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(86, 60);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(167, 22);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(86, 32);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(167, 22);
            this.textBox_Username.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prava:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username:";
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Location = new System.Drawing.Point(178, 270);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_Dodaj.TabIndex = 5;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Odustani
            // 
            this.button_Odustani.Location = new System.Drawing.Point(97, 270);
            this.button_Odustani.Name = "button_Odustani";
            this.button_Odustani.Size = new System.Drawing.Size(75, 23);
            this.button_Odustani.TabIndex = 6;
            this.button_Odustani.Text = "Odustani";
            this.button_Odustani.UseVisualStyleBackColor = true;
            this.button_Odustani.Click += new System.EventHandler(this.button_Odustani_Click);
            // 
            // NoviKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 305);
            this.Controls.Add(this.button_Odustani);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.checkedListBox_Prava);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoviKorisnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Korisnik";
            this.Load += new System.EventHandler(this.NoviKorisnikForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Prava;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.Button button_Odustani;
    }
}
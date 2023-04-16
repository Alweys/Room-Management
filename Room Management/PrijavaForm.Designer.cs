namespace Room_Management
{
    partial class PrijavaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.button_Prijava = new System.Windows.Forms.Button();
            this.button_NastaviKaoGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(91, 133);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 22);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Password_KeyPress);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(91, 105);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 22);
            this.textBox_Username.TabIndex = 4;
            this.textBox_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Username_KeyPress);
            // 
            // button_Prijava
            // 
            this.button_Prijava.Location = new System.Drawing.Point(68, 172);
            this.button_Prijava.Name = "button_Prijava";
            this.button_Prijava.Size = new System.Drawing.Size(75, 23);
            this.button_Prijava.TabIndex = 9;
            this.button_Prijava.Text = "Prijava";
            this.button_Prijava.UseVisualStyleBackColor = true;
            this.button_Prijava.Click += new System.EventHandler(this.button_Prijava_Click);
            // 
            // button_NastaviKaoGuest
            // 
            this.button_NastaviKaoGuest.Location = new System.Drawing.Point(44, 202);
            this.button_NastaviKaoGuest.Name = "button_NastaviKaoGuest";
            this.button_NastaviKaoGuest.Size = new System.Drawing.Size(123, 23);
            this.button_NastaviKaoGuest.TabIndex = 11;
            this.button_NastaviKaoGuest.Text = "Nastavi kao Guest";
            this.button_NastaviKaoGuest.UseVisualStyleBackColor = true;
            this.button_NastaviKaoGuest.Click += new System.EventHandler(this.button_NastaviKaoGuest_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 260);
            this.Controls.Add(this.button_NastaviKaoGuest);
            this.Controls.Add(this.button_Prijava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrijavaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrijavaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Button button_Prijava;
        private System.Windows.Forms.Button button_NastaviKaoGuest;
    }
}
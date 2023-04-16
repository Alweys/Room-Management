using SkolslkiKurikulum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Room_Management
{
    public partial class PrijavaForm : Form
    {
        private static String connStr = @"server=localhost\SQLEXPRESS;uid=room_mng;pwd=12345;database=room_management";

        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void login()
        {
            SqlConnection myConnection = new SqlConnection(connStr);
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select ID from Users where Username = '" + textBox_Username.Text + "' AND Password = '" + CCrypto.Encrypt(textBox_Password.Text) + "' AND Active = 'True'", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();
                bool loggedIn = false;
                while (myReader.Read())
                {
                    if (String.IsNullOrEmpty(myReader.GetValue(0).ToString()))
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka", "Prijava", MessageBoxButtons.OK);
                        return;
                    }
                    //MessageBox.Show("Uspješna prijava", "Prijava", MessageBoxButtons.OK);
                    loggedIn = true;
                    CKorisnik.dohvatiKorisnike();
                    CKorisnik.postaviTrenutni(CKorisnik.vratiKorisnikaPoIDu(myReader.GetInt32(0)));

                    this.DialogResult = DialogResult.OK;
                }
                if (!loggedIn)
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka", "Prijava", MessageBoxButtons.OK);
            }
            catch { }
            myConnection.Close();
        }

        private void button_Prijava_Click(object sender, EventArgs e)
        {
            login();
        }

        private void PrijavaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void textBox_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                login();
        }

        private void textBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                login();
        }

        private void button_NastaviKaoGuest_Click(object sender, EventArgs e)
        {
            CKorisnik.dohvatiKorisnike();
            CKorisnik.postaviTrenutni(CKorisnik.vratiKorisnikaPoImenu("guest"));

            this.DialogResult = DialogResult.OK;
        }
    }
}

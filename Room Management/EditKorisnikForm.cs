using SkolslkiKurikulum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Room_Management
{
    public partial class EditKorisnikForm : Form
    {
        public EditKorisnikForm()
        {
            InitializeComponent();
        }

        private void EditKorisnikForm_Load(object sender, EventArgs e)
        {
            comboBox_Korisnici.Items.Clear();
            foreach (CKorisnik k in CKorisnik.vratiKorisnike())
            {
                comboBox_Korisnici.Items.Add(k);
            }

            button_Obrisi.Enabled = false;
            CUserPrava.dohvatiPrava(CKorisnik.vratiTrenutni());
            if (CKorisnik.vratiTrenutni().provjeriPravo(CPravo.vratiPravoPoIDu(5))) // pravo 5 - Brisanje korisnika
                button_Obrisi.Enabled = true;
        }

        private void comboBox_Korisnici_SelectedIndexChanged(object sender, EventArgs e)
        {
            CKorisnik Korisnik = (CKorisnik)comboBox_Korisnici.SelectedItem;
            CUserPrava.dohvatiPrava(Korisnik);
            textBox_FullName.Text = Korisnik.vratiPunoIme();

            checkedListBox_Prava.Items.Clear();
            foreach (CPravo p in CPravo.vratiPrava())
                checkedListBox_Prava.Items.Add(p);
            for(int i = 1; i <= CPravo.vratiPrava().Count; i++)
            {
                if(Korisnik.provjeriPravo(CPravo.vratiPravoPoIDu(i)))
                {
                    checkedListBox_Prava.SetItemChecked(i-1, true);
                }
            }
        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_Uredi_Click(object sender, EventArgs e)
        {
            List<CPravo> checkedItemsList = new List<CPravo>();

            foreach (var item in checkedListBox_Prava.CheckedItems)
            {
                CPravo pravo = (CPravo)item;

                checkedItemsList.Add(pravo);
            }
            CKorisnik Korisnik = (CKorisnik)comboBox_Korisnici.SelectedItem;
            Korisnik.urediKorisnika(textBox_FullName.Text, checkedItemsList);

            this.DialogResult = DialogResult.OK;
        }

        private void button_Obrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati Korisnika?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CKorisnik Korisnik = (CKorisnik)comboBox_Korisnici.SelectedItem;
                Korisnik.obrisiKorisnika();
            }
            else
            {
                return;
            }
        }
    }
}

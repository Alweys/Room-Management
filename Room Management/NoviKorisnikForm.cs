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
    public partial class NoviKorisnikForm : Form
    {
        public NoviKorisnikForm()
        {
            InitializeComponent();
        }

        private void NoviKorisnikForm_Load(object sender, EventArgs e)
        {
            checkedListBox_Prava.Items.Clear();
            foreach (CPravo p in CPravo.vratiPrava())
                checkedListBox_Prava.Items.Add(p);
        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_Dodaj_Click(object sender, EventArgs e)
        {
            List<CPravo> checkedItemsList = new List<CPravo>();

            foreach (var item in checkedListBox_Prava.CheckedItems)
            {
                CPravo pravo = (CPravo)item;

                checkedItemsList.Add(pravo);
            }
            CKorisnik.dodajNovogKorisnika(textBox_Username.Text, textBox_Password.Text, textBox_FullName.Text
                , checkedItemsList);

            this.DialogResult = DialogResult.OK;
        }
    }
}

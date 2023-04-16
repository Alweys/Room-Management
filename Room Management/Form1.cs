using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SkolslkiKurikulum;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Room_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        List<string> dostupnaVremena = new List<string>();

        public List<(TimeSpan, TimeSpan)> GetReservedTimes(int roomId, DateTime date)
        {
            List<(TimeSpan, TimeSpan)> reservedTimes = new List<(TimeSpan, TimeSpan)>();
            String connectionString = @"server=localhost\SQLEXPRESS;uid=room_mng;pwd=12345;database=room_management";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PocetakID, KrajID FROM Rezervacije WHERE ProstorijaID = @roomId AND Datum = @date AND Aktivno = 'True'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@roomId", roomId);
                command.Parameters.AddWithValue("@date", date.Date);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int pocetakId = reader.GetInt32(0);
                        int krajId = reader.GetInt32(1);

                        TimeSpan pocetak = CVremena.vratiVrijemePoIDu(pocetakId).vratiVrijeme();
                        TimeSpan kraj = CVremena.vratiVrijemePoIDu(krajId).vratiVrijeme();

                        reservedTimes.Add((pocetak, kraj));
                    }
                }
            }

            return reservedTimes;
        }

        private void ucitajVremena()
        {
            var reservedTimes = GetReservedTimes((comboBox_Prostorije2.SelectedItem as CProstorija).vratiID(), monthCalendar_Datum.SelectionRange.Start);
            var allTimes = new List<DateTime>();
            allTimes = CVremena.vratiVremena();

            var availableTimes = new List<string>();

            foreach (var time in allTimes)
            {
                bool isReserved = false;
                foreach (var reservedTime in reservedTimes)
                {
                    if (time.TimeOfDay >= reservedTime.Item1 && time.TimeOfDay < reservedTime.Item2)
                    {
                        isReserved = true;
                        break;
                    }
                }
                if (!isReserved)
                {
                    availableTimes.Add(time.ToString("HH:mm"));
                }
            }
            dostupnaVremena = availableTimes;

            comboBox_Pocetak.Items.Clear();
            foreach (string s in availableTimes)
            {
                comboBox_Pocetak.Items.Add(s);
                comboBox_Pocetak.SelectedIndex = 0;

            }

            if (availableTimes.Count > 0)
                availableTimes.RemoveAt(0);


            comboBox_Kraj.Items.Clear();
            foreach (string s in availableTimes)
            {
                comboBox_Kraj.Items.Add(s);
                comboBox_Kraj.SelectedIndex = 0;
            }
        }

        private void ucitajProstorije2()
        {
            comboBox_Prostorije2.Items.Clear();

            foreach (CProstorija p in CProstorija.vratiProstorije())
                comboBox_Prostorije2.Items.Add(p);

            comboBox_Prostorije2.SelectedIndex = 0;
        }

        private void ucitajPonavljanja()
        {
            comboBox_Ponavljanja.Items.Clear();

            foreach (CPonavljanje p in CPonavljanje.vratiPonavljanja())
                comboBox_Ponavljanja.Items.Add(p);

            comboBox_Ponavljanja.SelectedIndex = 0;
        }

        private void provjeriPrava(CKorisnik TrenutniKorisnik)
        {
            panel_NovaRezervacija.Enabled = false;
            if (TrenutniKorisnik.provjeriPravo(CPravo.vratiPravoPoIDu(1))) // pravo 1 - Rezerviranje prostorije
            {
                CVremena.dohvatiVremena();
                CPonavljanje.dohvatiPonavljanja();
                ucitajProstorije2();
                ucitajVremena();
                ucitajPonavljanja();

                panel_NovaRezervacija.Enabled = true;
            }


            obrišiToolStripMenuItem.Enabled = false;
            if (TrenutniKorisnik.provjeriPravo(CPravo.vratiPravoPoIDu(2))) // pravo 2 - Brisanje rezervacija
            {
                obrišiToolStripMenuItem.Enabled = true;
            }

            monthCalendar_Datum.Enabled = false;
            listBox_Rezervacije.Items.Clear();
            listBox_Rezervacije.Enabled = false;
            comboBox_Prostorije.Enabled = false;
            if (TrenutniKorisnik.provjeriPravo(CPravo.vratiPravoPoIDu(3))) // pravo 3 - Pregled rezervacija
            {
                CVremena.dohvatiVremena();
                CPonavljanje.dohvatiPonavljanja();
                CRezervacija.dohvatiRezervacije(monthCalendar_Datum.SelectionRange.Start);
                CRezervacija.dohvatiPonavljajuceRezervacije();
                listBox_Rezervacije.Items.Clear();
                foreach (CRezervacija r in CRezervacija.vratiRezervacije())
                    listBox_Rezervacije.Items.Add(r);
                listBox_Rezervacije.Enabled = true;
                monthCalendar_Datum.Enabled = true;
                comboBox_Prostorije.Enabled = true;
                ucitajRezervacije();
            }

            dodajKorisnikaToolStripMenuItem.Enabled = false;
            if (TrenutniKorisnik.provjeriPravo(CPravo.vratiPravoPoIDu(4))) // pravo 4 - Dodavanje korisnika
            {
                dodajKorisnikaToolStripMenuItem.Enabled = true;
            }
            
            urediKorisnikeToolStripMenuItem.Enabled = false;
            if (TrenutniKorisnik.provjeriPravo(CPravo.vratiPravoPoIDu(6))) // pravo 6 - Uređivanje korisnika
            {
                urediKorisnikeToolStripMenuItem.Enabled = true;
            }
        }

        private void prijava()
        {
            PrijavaForm form = new PrijavaForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CPravo.dohvatiPrava();
                CKorisnik.dohvatiKorisnike();
                CProstorija.dohvatiProstorije();
                ucitajProstorije();

                label_Rezervacije.Text = "Prostorija\tPocetak - Kraj\tPonavljanje\tRezervirao".Replace("\t", "    "); ;
                this.Text = "Room Management - " + CKorisnik.vratiTrenutni().vratiPunoIme();

                CUserPrava.dohvatiPrava(CKorisnik.vratiTrenutni());
                provjeriPrava(CKorisnik.vratiTrenutni());
            }
        }

        private void ucitajProstorije()
        {
            comboBox_Prostorije.Items.Clear();

            comboBox_Prostorije.Items.Add("Sve");
            foreach (CProstorija p in CProstorija.vratiProstorije())
                comboBox_Prostorije.Items.Add(p);

            comboBox_Prostorije.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar_Datum.SelectionRange.Start = DateTime.Now;
            monthCalendar_Datum.SelectionRange.End = DateTime.Now;
            prijava();
        }

        private void ucitajRezervacije()
        {
            listBox_Rezervacije.Items.Clear();

            if (comboBox_Prostorije.SelectedIndex == 0) // Sve Rezervacije
            {
                if (CRezervacija.vratiRezervacije().Count == 0)
                {
                    //listBox_Rezervacije.Items.Add("Nema Rezervacija");
                    listBox_Rezervacije.Enabled = false;
                    return;
                }
                foreach (CRezervacija r in CRezervacija.vratiRezervacije())
                    listBox_Rezervacije.Items.Add(r);
                listBox_Rezervacije.Enabled = true;
            }
            else
            {
                if (CRezervacija.vratiRezervacijuPoProstoriji((CProstorija)comboBox_Prostorije.SelectedItem).Count == 0)
                {
                    //listBox_Rezervacije.Items.Add("Nema Rezervacija");
                    listBox_Rezervacije.Enabled = false;
                    return;
                }
                foreach (CRezervacija r in CRezervacija.vratiRezervacijuPoProstoriji((CProstorija)comboBox_Prostorije.SelectedItem))
                    listBox_Rezervacije.Items.Add(r);
                listBox_Rezervacije.Enabled = true;
            }
        }

        private void ucitajPonavljajuceRezervacije()
        {
            //listBox_Rezervacije.Items.Clear();
            DateTime selectedDate = monthCalendar_Datum.SelectionRange.Start;

            if (comboBox_Prostorije.SelectedIndex == 0) // Sve Rezervacije
            {
                if (CRezervacija.vratiPonavljajuceRezervacije().Count == 0)
                {
                    //listBox_Rezervacije.Items.Add("Nema Ponavljajucih Rezervacija");
                    listBox_Rezervacije.Enabled = false;
                    return;
                }
                foreach (CRezervacija r in CRezervacija.vratiPonavljajuceRezervacije())
                    if (r.vratiDatum().Date == selectedDate.Date ||
            (r.vratiPonavljanje().ToString() == "Tjedno" && r.vratiDatum().DayOfWeek == selectedDate.DayOfWeek) ||
            (r.vratiPonavljanje().ToString() == "Mjesečno" && r.vratiDatum().Day == selectedDate.Day))
                        if(!listBox_Rezervacije.Items.Contains(r))
                            listBox_Rezervacije.Items.Add(r);
                listBox_Rezervacije.Enabled = true;
            }
            else
            {
                if (CRezervacija.vratiRezervacijuPoProstoriji((CProstorija)comboBox_Prostorije.SelectedItem, CRezervacija.vratiPonavljajuceRezervacije()).Count == 0)
                {
                    //listBox_Rezervacije.Items.Add("Nema Ponavljajucih Rezervacija");
                    listBox_Rezervacije.Enabled = false;
                    return;
                }
                foreach (CRezervacija r in CRezervacija.vratiRezervacijuPoProstoriji((CProstorija)comboBox_Prostorije.SelectedItem, CRezervacija.vratiPonavljajuceRezervacije()))
                    if (/*r.vratiDatum().Date == selectedDate.Date ||*/
            (r.vratiPonavljanje().ToString() == "Tjedno" && r.vratiDatum().DayOfWeek == selectedDate.DayOfWeek) ||
            (r.vratiPonavljanje().ToString() == "Mjesečno" && r.vratiDatum().Day == selectedDate.Day))
                        if (!listBox_Rezervacije.Items.Contains(r))
                            listBox_Rezervacije.Items.Add(r);
                listBox_Rezervacije.Enabled = true;
            }
        }

        private void monthCalendar_Datum_DateChanged(object sender, DateRangeEventArgs e)
        {
            CRezervacija.dohvatiRezervacije(monthCalendar_Datum.SelectionRange.Start);
            ucitajRezervacije();
            CRezervacija.dohvatiPonavljajuceRezervacije();
            ucitajPonavljajuceRezervacije();
            if (CKorisnik.vratiTrenutni().provjeriPravo(CPravo.vratiPravoPoIDu(1))) // pravo 1 - Rezerviranje prostorije
                ucitajVremena();
        }

        private void comboBox_Prostorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajRezervacije();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Room Management";
            prijava();
        }

        private void listBox_Rezervacije_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBox_Rezervacije.IndexFromPoint(e.Location);
                if (index == listBox_Rezervacije.SelectedIndex)
                {
                    contextMenuStrip1.Show(listBox_Rezervacije.PointToScreen(e.Location));
                }
            }
        }

        private void obrišiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Jeste li sigurni da želite obrisati Rezervaciju?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CRezervacija ucitanaRezervacija = ((CRezervacija)listBox_Rezervacije.SelectedItem);
                ucitanaRezervacija.obrisiRezervaciju();
                CRezervacija.vratiRezervacije().Remove(ucitanaRezervacija);
                ucitanaRezervacija = null;
                provjeriPrava(CKorisnik.vratiTrenutni());
            }
            else
            {
                return;
            }
        }

        private void comboBox_Prostorije2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CKorisnik.vratiTrenutni().provjeriPravo(CPravo.vratiPravoPoIDu(1))) // pravo 1 - Rezerviranje prostorije
                ucitajVremena();
        }

        private void comboBox_Pocetak_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Kraj.Items.Clear();
            for(int i = comboBox_Pocetak.SelectedIndex; i < dostupnaVremena.Count; i++)
            {
                comboBox_Kraj.Items.Add(dostupnaVremena[i]);
                comboBox_Kraj.SelectedIndex = 0;
            }
        }

        private void comboBox_Kraj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_DodajRezervaciju_Click(object sender, EventArgs e)
        {
            CRezervacija.KreirajNovuRezervaciju(monthCalendar_Datum.SelectionRange.Start, CKorisnik.vratiTrenutni(), comboBox_Pocetak.Text, comboBox_Kraj.Text, (CProstorija)comboBox_Prostorije2.SelectedItem, (CPonavljanje)comboBox_Ponavljanja.SelectedItem);
            provjeriPrava(CKorisnik.vratiTrenutni());
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPravo.dohvatiPrava();
            NoviKorisnikForm form = new NoviKorisnikForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void urediKorisnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPravo.dohvatiPrava();
            EditKorisnikForm form = new EditKorisnikForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CUserPrava.dohvatiPrava(CKorisnik.vratiTrenutni());
                provjeriPrava(CKorisnik.vratiTrenutni());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SkolslkiKurikulum;
using System.Windows.Forms;
using System.Diagnostics;

namespace Room_Management
{
    public class CRezervacija
    {
        private static List<CRezervacija> Rezervacije = new List<CRezervacija>();
        private static List<CRezervacija> PonavljajuceRezervacije = new List<CRezervacija>();
        private int ID;
        private DateTime Datum;
        private CKorisnik Korisnik;
        private CVremena Pocetak, Kraj;
        private CProstorija Prostorija;
        private CPonavljanje Ponavljanje;
        private bool Aktivno;

        private CRezervacija(int iD, DateTime datum, CKorisnik korisnik, CVremena pocetak, CVremena kraj, CProstorija prostorija, CPonavljanje ponavljanje, bool aktivno)
        {
            ID = iD;
            Datum = datum;
            Korisnik = korisnik;
            Pocetak = pocetak;
            Kraj = kraj;
            Prostorija = prostorija;
            Ponavljanje = ponavljanje;
            Aktivno = aktivno;
        }

        public static void dohvatiRezervacije(DateTime Datum)
        {
            Rezervacije.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Rezervacije where Datum = '" + Datum.ToString("yyyy-MM-dd")  + "' AND Aktivno = 'True' ORDER BY [ProstorijaID]", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Rezervacije.Add(new CRezervacija(
                        myReader.GetInt32(0),
                        myReader.GetDateTime(1),
                        CKorisnik.vratiKorisnikaPoIDu(myReader.GetInt32(2)),
                        CVremena.vratiVrijemePoIDu(myReader.GetInt32(3)),
                        CVremena.vratiVrijemePoIDu(myReader.GetInt32(4)),
                        CProstorija.vratiProstorijuPoIDu(myReader.GetInt32(5)),
                        CPonavljanje.vratiPonavljanjePoIDu(myReader.GetInt32(6)),
                        myReader.GetBoolean(7)
                        ));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Rezervacija iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static void dohvatiPonavljajuceRezervacije()
        {
            PonavljajuceRezervacije.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Rezervacije where PonavljanjeID > 1 AND Aktivno = 'True' ORDER BY [ProstorijaID]", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    PonavljajuceRezervacije.Add(new CRezervacija(
                        myReader.GetInt32(0),
                        myReader.GetDateTime(1),
                        CKorisnik.vratiKorisnikaPoIDu(myReader.GetInt32(2)),
                        CVremena.vratiVrijemePoIDu(myReader.GetInt32(3)),
                        CVremena.vratiVrijemePoIDu(myReader.GetInt32(4)),
                        CProstorija.vratiProstorijuPoIDu(myReader.GetInt32(5)),
                        CPonavljanje.vratiPonavljanjePoIDu(myReader.GetInt32(6)),
                        myReader.GetBoolean(7)
                        ));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Ponavljajucih Rezervacija iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public void obrisiRezervaciju()
        {
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("update Rezervacije set Aktivno = 'False' where ID = " + this.ID, myConnection);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Greška pri brisanju Rezervacije iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static List<CRezervacija> vratiRezervacijuPoProstoriji(CProstorija prostorija)
        {
            List<CRezervacija> RezervacijeTemp = new List<CRezervacija>();

            foreach (CRezervacija r in Rezervacije)
            {
                if (r.Prostorija.ToString().Equals(prostorija.ToString()))
                {
                    RezervacijeTemp.Add(r);
                }
            }

            return RezervacijeTemp;
        }

        public static List<CRezervacija> vratiRezervacijuPoProstoriji(CProstorija prostorija, List<CRezervacija> rezervacija)
        {
            List<CRezervacija> RezervacijeTemp = new List<CRezervacija>();

            foreach (CRezervacija r in rezervacija)
            {
                if (r.Prostorija.ToString().Equals(prostorija.ToString()))
                {
                    RezervacijeTemp.Add(r);
                }
            }

            return RezervacijeTemp;
        }

        public static void KreirajNovuRezervaciju(DateTime Datum, CKorisnik Korisnik, string Pocetak, string Kraj, CProstorija Prostorija, CPonavljanje Ponavljanje)
        {
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            myConnection.Open();
            string sql = "INSERT INTO Rezervacije(Datum, UserID, PocetakID, KrajID, ProstorijaID, PonavljanjeID, Aktivno) VALUES" +
                "(@Datum, @UserID, @PocetakID, @KrajID, @ProstorijaID, @PonavljanjeID, 'True'); ";

            SqlCommand myCommand = new SqlCommand(sql, myConnection);
            myCommand.Parameters.AddWithValue("@Datum", Datum.ToString("yyyy-MM-dd"));
            myCommand.Parameters.AddWithValue("@UserID", Korisnik.vratiID());
            myCommand.Parameters.AddWithValue("@PocetakID", CVremena.vratiVrijemePoStringu(Pocetak).vratiID());
            myCommand.Parameters.AddWithValue("@KrajID", CVremena.vratiVrijemePoStringu(Kraj).vratiID());
            myCommand.Parameters.AddWithValue("@ProstorijaID", Prostorija.vratiID());
            myCommand.Parameters.AddWithValue("@PonavljanjeID", Ponavljanje.vratiID());

            Debug.WriteLine(myCommand.CommandText);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Greška pri Dodavanju Nove Rezervacije u bazu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            myConnection.Close();
        }

        public static List<CRezervacija> vratiRezervacije()
        {
            return Rezervacije;
        }
        
        public static List<CRezervacija> vratiPonavljajuceRezervacije()
        {
            return PonavljajuceRezervacije;
        }

        public DateTime vratiDatum()
        {
            return Datum;
        }

        public CPonavljanje vratiPonavljanje()
        {
            return Ponavljanje;
        }

        public override string ToString()
        {
            return Prostorija + "\t" + Pocetak + " - " + Kraj + "\t" + Ponavljanje + "\t" + Korisnik.vratiPunoIme();
        }
    }
}

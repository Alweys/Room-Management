using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SkolslkiKurikulum;
using System.Windows.Forms;

namespace Room_Management
{
    public class CVremena
    {
        private static List<CVremena> Vremena = new List<CVremena>();
        private int ID;
        private DateTime Pocetak;

        private CVremena(int iD, DateTime pocetak)
        {
            ID = iD;
            Pocetak = pocetak;
        }

        public static void dohvatiVremena()
        {
            Vremena.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Vremena", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Vremena.Add(new CVremena(
                        myReader.GetInt32(0),
                        myReader.GetDateTime(1)));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Vremena iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static CVremena vratiVrijemePoIDu(int ID)
        {
            foreach (CVremena v in Vremena)
                if (v.ID == ID)
                    return v;
            return null;
        }

        public static CVremena vratiVrijemePoStringu(string vrijeme)
        {
            foreach (CVremena v in Vremena)
                if (v.Pocetak.ToString("HH:mm").Equals(vrijeme))
                    return v;
            return null;
        }

        public static List<DateTime> vratiVremena()
        {
            List < DateTime > temp = new List<DateTime>();

            foreach(CVremena v in Vremena)
                temp.Add(v.Pocetak);

            return temp;
        }

        public TimeSpan vratiVrijeme()
        {
            return Pocetak.TimeOfDay;
        }

        public int vratiID()
        {
            return ID;
        }

        public override string ToString()
        {
            return Pocetak.ToString("HH:mm");
        }
    }
}

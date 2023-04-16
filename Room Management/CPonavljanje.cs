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
    public class CPonavljanje
    {
        private static List<CPonavljanje> Ponavljanja = new List<CPonavljanje>();
        private int ID;
        private string Vrsta;

        private CPonavljanje(int iD, string vrsta)
        {
            ID = iD;
            Vrsta = vrsta;
        }

        public static void dohvatiPonavljanja()
        {
            Ponavljanja.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Ponavljanja", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Ponavljanja.Add(new CPonavljanje(
                        myReader.GetInt32(0),
                        myReader.GetString(1)));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Ponavljanja iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static CPonavljanje vratiPonavljanjePoIDu(int ID)
        {
            foreach (CPonavljanje p in Ponavljanja)
                if (p.ID == ID)
                    return p;
            return null;
        }

        public static List<CPonavljanje> vratiPonavljanja()
        {
            return Ponavljanja;
        }

        public int vratiID()
        {
            return ID;
        }

        public override string ToString()
        {
            return Vrsta;
        }
    }
}

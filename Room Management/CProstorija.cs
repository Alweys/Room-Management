using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Room_Management
{
    public class CProstorija
    {
        private static List<CProstorija> Prostorije = new List<CProstorija>();
        private int ID;
        private string Prostorija;

        private CProstorija(int iD, string prostorija)
        {
            ID = iD;
            Prostorija = prostorija;
        }

        public static void dohvatiProstorije()
        {
            Prostorije.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Prostorija", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Prostorije.Add(new CProstorija(
                        myReader.GetInt32(0),
                        myReader.GetString(1)));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Prostorija iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static CProstorija vratiProstorijuPoIDu(int ID)
        {
            foreach (CProstorija p in Prostorije)
                if (p.ID == ID)
                    return p;
            return null;
        }

        public static List<CProstorija> vratiProstorije()
        {
            return Prostorije;
        }
        
        public int vratiID()
        {
            return ID;
        }

        public override string ToString()
        {
            return Prostorija;
        }
    }
}

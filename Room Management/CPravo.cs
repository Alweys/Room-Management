using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Room_Management;

namespace SkolslkiKurikulum
{
    public class CPravo
    {
        private static List<CPravo> Prava = new List<CPravo>();
        private int ID;
        private string Naziv;

        private CPravo(int ID, string Naziv)
        {
            this.ID = ID;
            this.Naziv = Naziv;
        }

        public static void dohvatiPrava()
        {
            Prava.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from Prava", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Prava.Add(new CPravo(
                        myReader.GetInt32(0),
                        myReader["Naziv"].ToString()));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Prava iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static CPravo vratiPravoPoIDu(int ID)
        {
            foreach (CPravo p in Prava)
                if (p.ID == ID)
                    return p;
            return null;
        }

        public static List<CPravo> vratiPrava()
        {
            return Prava;
        }

        public int vratiID()
        {
            return ID;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
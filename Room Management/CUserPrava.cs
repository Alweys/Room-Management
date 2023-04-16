using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using SkolslkiKurikulum;
using System.Windows.Forms;

namespace Room_Management
{
    public class CUserPrava
    {
        private CPravo Pravo;
        private bool Aktivno;

        private CUserPrava(CPravo pravo, bool aktivno)
        {
            this.Pravo = pravo;
            this.Aktivno = aktivno;
        }

        public static void dohvatiPrava(CKorisnik Korisnik)
        {
            Korisnik.vratiPrava().Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from UserPrava where UserID = " + Korisnik.vratiID() + " AND Aktivno = 'True'", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    CPravo pravo = CPravo.vratiPravoPoIDu(myReader.GetInt32(2));
                    if (pravo == null)
                        continue;

                    bool aktivno = myReader.GetBoolean(3);

                    Korisnik.vratiPrava().Add(new CUserPrava(pravo, aktivno));
                }
            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Prava Korisnika iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public CPravo vratiPravo()
        {
            return Pravo;
        }

        public override string ToString()
        {
            return Pravo.ToString();
        }
    }
}

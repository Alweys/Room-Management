using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Room_Management;

namespace SkolslkiKurikulum
{
    public class CKorisnik
    {
        private static List<CKorisnik> Korisnici = new List<CKorisnik>();
        private static List<CUserPrava> Prava = new List<CUserPrava>();
        private static CKorisnik trenutniKorisnik;
        private int ID;
        private string Username, FullName;
        private bool Aktivno;

        private CKorisnik(int ID, string Username, string FullName, bool Aktivno)
        {
            this.ID = ID;
            this.Username = Username;
            this.FullName = FullName;
            this.Aktivno = Aktivno;
        }

        public static void dohvatiKorisnike()
        {
            Korisnici.Clear();
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            SqlDataReader myReader = null;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select ID, Username, FullName, Active from Users where Active = 'True'", myConnection);
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Korisnici.Add(new CKorisnik(
                        myReader.GetInt32(0),
                        myReader["Username"].ToString(),
                        myReader["FullName"].ToString(),
                        myReader.GetBoolean(3)));
                }

            }
            catch
            {
                MessageBox.Show("Greška pri dohvaćanju Korisnika iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static bool dodajNovogKorisnika(string Username, string Password, string FullName, List<CPravo> Prava)
        {
            foreach (CKorisnik k in Korisnici)
            {
                if (k.Username == Username)
                {
                    MessageBox.Show("Korisnik već postoji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            myConnection.Open();
            string cmd = "insert into Users values(@Username, @Password, @FullName, 'True')" +
                "DECLARE @UserID INT; set @UserID = SCOPE_IDENTITY(); ";

            foreach (CPravo p in CPravo.vratiPrava())
            {
                if (Prava.Contains(p))
                {
                    cmd += "insert into UserPrava values(@UserID, '" + p.vratiID() + "', 'True'); ";
                }
                else
                {
                    cmd += "insert into UserPrava values(@UserID, '" + p.vratiID() + "', 'False'); ";
                }
            }

            SqlCommand myCommand = new SqlCommand(cmd, myConnection);

            myCommand.Parameters.AddWithValue("@Username", Username);
            myCommand.Parameters.AddWithValue("@Password", CCrypto.Encrypt(Password));
            myCommand.Parameters.AddWithValue("@FullName", FullName);

            try
            {
                //Debug.WriteLine(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Greška pri dodavanju novog Korisnika", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            myConnection.Close();
            dohvatiKorisnike();
            return true;
        }

        public void obrisiKorisnika()
        {
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("update Users set Active = 'False' where ID = " + this.ID, myConnection);
            try
            {
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Greška pri brisanju Korisnika iz baze", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public void urediKorisnika(string fullname, List<CPravo> Prava)
        {
            SqlConnection myConnection = CKonekcija.Instance.myConnection;
            myConnection.Open();

            string sql = "UPDATE Users SET FullName = @FullName WHERE ID = @UserID; ";

            foreach (CPravo p in CPravo.vratiPrava())
            {
                if (Prava.Contains(p))
                {
                    sql += "update UserPrava set Aktivno = 'True' where UserID = @UserID AND PravoID = '" + p.vratiID() + "';";
                }
                else
                {
                    sql += "update UserPrava set Aktivno = 'False' where UserID = @UserID AND PravoID = '" + p.vratiID() + "';";
                }
            }

            SqlCommand myCommand = new SqlCommand(sql, myConnection);
            myCommand.Parameters.AddWithValue("@FullName", fullname);
            myCommand.Parameters.AddWithValue("@UserID", this.ID);
            try
            {
                Debug.WriteLine(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Greška pri uređivanju Vrednovanja u bazi", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            myConnection.Close();
        }

        public static List<CKorisnik> vratiKorisnike()
        {
            return Korisnici;
        }

        public static CKorisnik vratiKorisnikaPoImenu(string Username)
        {
            foreach (CKorisnik k in Korisnici)
                if (k.Username == Username)
                    return k;
            return null;
        }

        public static CKorisnik vratiKorisnikaPoIDu(int ID)
        {
            foreach (CKorisnik k in Korisnici)
                if (k.ID == ID)
                    return k;
            return null;
        }

        public bool provjeriPravo(CPravo pravo)
        {
            foreach (CUserPrava p in vratiPrava())
                if (p.vratiPravo() == pravo)
                    return true;
            return false;
        }

        public static void postaviTrenutni(CKorisnik Korisnik)
        {
            trenutniKorisnik = Korisnik;
        }

        public static CKorisnik vratiTrenutni()
        {
            return trenutniKorisnik;
        }

        public string vratiPunoIme()
        {
            return FullName;
        }

        public int vratiID()
        {
            return ID;
        }

        public List<CUserPrava> vratiPrava()
        {
            return Prava;
        }

        public override string ToString()
        {
            return Username + " - " + FullName;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Management
{
    public class CKonekcija
    {
        private CKonekcija() {
            myConnection = new SqlConnection(connStr);
        }
        private static String connStr = @"server=localhost\SQLEXPRESS;uid=room_mng;pwd=12345;database=room_management";
        public SqlConnection myConnection { get; }

        private static CKonekcija instance = null;
        public static CKonekcija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CKonekcija();
                }
                return instance;
            }
        }


    }
}

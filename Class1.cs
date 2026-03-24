using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Samostalni_2026_Pavle_StanojevicB
{
    internal class Konekcija
    {
        string CS = "Data Source= NAZIV SERVERA;Initial Catalog= IME BAZE; Integrated Security = True;";

        static public SqlConnection povezi() {
            SqlConnection conn = new SqlConnection(CS);
            return conn;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Samostalni_2026_Pavle_StanojevicB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ulogujSeBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konekcija.povezi();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Korisnici where email="+textBox1.Text, conn);
        }
    }
}

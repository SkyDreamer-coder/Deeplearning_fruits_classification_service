using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Meyve_bankasi_app
{
    internal class Database
    {
        private string dbConnection;
        public Database(string dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public void Connect()
        {
            try
            {
                SqlConnection con = new SqlConnection(this.dbConnection);
                MessageBox.Show("sql bağlantı başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql connection hatası " + ex.ToString());
                Application.Exit();
            }
        }
    }
}

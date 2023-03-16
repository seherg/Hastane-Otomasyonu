using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_center_management
{ 
    class Database
    {
        
        //connection to database
        //SqlConnection conn = new SqlConnection("Data Source=SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        // select 
        public DataTable readData(string stmt, string message)
        {
            DataTable Tablel = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                //load data from database to tbl 
                Tablel.Load(cmd.ExecuteReader());

                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return Tablel;
        }

        // insert update delete 
        public bool exceuteData(string stmt, string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}

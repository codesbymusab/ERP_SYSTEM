using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;

namespace ERP_System
{
    class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {

            string conString = ConfigurationManager.ConnectionStrings["ErpDb"]?.ConnectionString;
            if (string.IsNullOrEmpty(conString))
            {
                throw new InvalidOperationException("Connection string 'MiniErpDb' not found in app.config.");
            }
            con = new SqlConnection(conString);



        }

        public SqlConnection Con { get => con; }

        public void checkConnection()
        {

            try
            {
                Con.Open();
                string queryString = "SELECT * FROM Users;";

                SqlCommand com = new SqlCommand(queryString, Con);
               
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader["Username"] as String);
                }
                
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Con.Close();
            }
        }
      
    }


}

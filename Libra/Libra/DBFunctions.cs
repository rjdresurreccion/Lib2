using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra
{
    public class DBFunctions
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Library"].ConnectionString);

        public bool GetBook(int Serial)
        {
            string Title, Author, Genre;

            try
            {
                SqlCommand cmd1 = new SqlCommand("SPBReturnBooks", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@SerialNumber", Serial);



                SqlCommand cmd = new SqlCommand("SPIGetBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SerialNumber", Serial);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
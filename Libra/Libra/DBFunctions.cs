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

        public DataTable GetBookInventory(int Serial)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT " + Serial + " FROM EmployeeDatabase", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AddBookToBorrowed(int Serial, string Title, string Author, string Genre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SPBReturnBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@Genre", Genre);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddBookToInventory(int Serial, string Title, string Author, string Genre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SPIReturnBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@Genre", Genre);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveBookToBorrowed(int Serial, string Title, string Author, string Genre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SPBGetBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@Genre", Genre);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveBookToInventory(int Serial, string Title, string Author, string Genre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SPIGetBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@Genre", Genre);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand cmd;
        SqlDataReader data;
        public List<TaiKhoan> TK (string query)
            {
            List<TaiKhoan> Tk = new List<TaiKhoan>();
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query,con);
                data = cmd.ExecuteReader();
                while( data.Read())
                {
                    Tk.Add(new TaiKhoan(data.GetString(1), data.GetString(2)));
                }    
                con.Close(); 
            }
            return Tk;
            }
        public void CMD(string query)
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            } 
                
        }

    }
}

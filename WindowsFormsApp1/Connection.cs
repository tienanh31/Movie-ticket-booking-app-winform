    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
namespace WindowsFormsApp1
{
    class Connection
    {
        public static string con = @"Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True";
        public  static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(con); 
        }
    }
}

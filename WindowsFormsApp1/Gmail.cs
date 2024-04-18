using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Gmail : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;

        public Mail item = new Mail();
        public Gmail()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
        }

        private void Gmail_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM SUPPORT", con);
            data = cmd.ExecuteReader();

            while (data.Read())
            {

                item = new Mail();
                item.ID = data["ID"].ToString();
                item.TEN = data["HOTEN"].ToString();
                item.GMAIL = data["GMAIL"].ToString();
                item.SDT = data["SDT"].ToString();
                item.GOPY = data["NOIDUNG"].ToString();          
                flowLayoutPanel1.Controls.Add(item);
            }
            con.Close();
            data.Close();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

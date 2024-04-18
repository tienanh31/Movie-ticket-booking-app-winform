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
using System.Net;
namespace WindowsFormsApp1
{
    public partial class News : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public Iteam_Newss news = new Iteam_Newss();
        public News()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
        }

        private void News_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT POSTER,TIEUDE,NOIDUNG  FROM NEWS", con);
            data = cmd.ExecuteReader();

            while (data.Read())
            {

                news = new Iteam_Newss();
                news.TIEUDE = data["TIEUDE"].ToString();
                news.NOIDUNG = data["NOIDUNG"].ToString();
                news.POSTER = data["POSTER"].ToString();

                    flowLayoutPanel1.Controls.Add(news);


                

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            AddNews add = new AddNews();
            add.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

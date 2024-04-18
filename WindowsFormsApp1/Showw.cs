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
    public partial class Showw : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;

        public Show item = new Show();
        public Showw()
        { 
      
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
        }
        private void MOVIE_SHOW_Load(object sender, EventArgs e)
        {
          
        }
        private void show1_Load(object sender, EventArgs e)
        {

        }


        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT IDSUATCHIEU,IDPHIM,Rap,IDPHONG,NGAYCHIEU FROM SHOW WHERE IDSUATCHIEU LIKE'" + bunifuTextBox1.Text + "%' ORDER  BY IDSUATCHIEU", con);
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                while (data.Read())
                {
                    item = new Show();
                    item.IDSUAT = data["IDSUATCHIEU"].ToString();
                    item.RAP = data["Rap"].ToString();
                    item.PHONGCHIEU = data["IDPHONG"].ToString();                
                    item.IDPHIM = data["IDPHIM"].ToString();
                    item.NGAYCHIEU = data["NGAYCHIEU"].ToString();
                   
                    flowLayoutPanel1.Controls.Add(item);
                    
                }
            }
            con.Close();
            data.Close();

        }
        private void Showw_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            AddShow add = new AddShow();
            add.StartPosition = FormStartPosition.CenterScreen;
            add.Show();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

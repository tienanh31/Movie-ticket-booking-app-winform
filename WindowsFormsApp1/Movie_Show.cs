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

    public partial class Movie_Show : Form
    {
        SqlConnection con ;
        SqlCommand cmd ;
        SqlDataReader data;

        public Moviee_Show item = new Moviee_Show();

        private void moviee_Show1_Load(object sender, EventArgs e)
        {

        }

        private void moviee_Show1_Load_1(object sender, EventArgs e)
        {

        }

        public Movie_Show()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
            
        }

        private void MOVIE_SHOW_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT * FROM MOVIE WHERE TENPHIM LIKE'" + bunifuTextBox1.Text + "%' ORDER  BY TENPHIM", con);
            data = cmd.ExecuteReader();
           
            while (data.Read())
            {
               
                    item = new Moviee_Show();
                    item.Tag = data["TENPHIM"].ToString();
                    item.TENPHIM = data["TENPHIM"].ToString();
                    item.IDPHIM = data["IDPHIM"].ToString();
                    item.THELOAI = data["THELOAI"].ToString();
                    item.THOILUONG = data["THOILUONG"].ToString();
                    item.POSTER = data["POSTER"].ToString();
                    item.DEMO = data["DEMO"].ToString();
                    item.NGAYKHOICHIEU = data["NGAYKHOICHIEU"].ToString();
                    item.QUOCGIA = data["QUOCGIA"].ToString();
                    item.DAODIEN = data["DAODIEN"].ToString();
                    item.DIENVIEN = data["DIENVIEN"].ToString();
                    item.MOTA = data["MOTA"].ToString();
             
                    string req = "";
                    req = data["POSTER"].ToString();
                    var request = WebRequest.Create(req);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {

                        item.PIC = Bitmap.FromStream(stream);
                        flowLayoutPanel1.Controls.Add(item);
                    }
                
            }
            con.Close();
            data.Close();
      

        }

     

        //public void GETDATA()
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    con.Open();
        //    cmd = new SqlCommand("SELECT * FROM MOVIE WHERE TENPHIM LIKE'" + bunifuTextBox1.Text + "%' ORDER  BY TENPHIM", con);
        //    data = cmd1.ExecuteReader();

        //    while (data.Read())
        //    {

        //        item = new Moviee_Show();
        //        item.Tag = data["TENPHIM"].ToString();
        //        item.TENPHIM = data["TENPHIM"].ToString();
        //        item.IDPHIM = data["IDPHIM"].ToString();
        //        item.THELOAI = data["THELOAI"].ToString();
        //        item.THOILUONG = data["THOILUONG"].ToString();
        //        item.POSTER = data["POSTER"].ToString();
        //        item.DEMO = data["DEMO"].ToString();
        //        item.NGAYKHOICHIEU = data["NGAYKHOICHIEU"].ToString();
        //        item.QUOCGIA = data["QUOCGIA"].ToString();
        //        item.DAODIEN = data["DAODIEN"].ToString();
        //        item.DIENVIEN = data["DIENVIEN"].ToString();
        //        item.MOTA = data["MOTA"].ToString();

        //        string req = "";
        //        req = data["POSTER"].ToString();
        //        var request = WebRequest.Create(req);
        //        using (var response = request.GetResponse())
        //        using (var stream = response.GetResponseStream())
        //        {

        //            item.PIC = Bitmap.FromStream(stream);
        //            flowLayoutPanel1.Controls.Add(item);
        //        }

        //    }
        //}
            private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddMovie add = new AddMovie();
            add.StartPosition = FormStartPosition.CenterScreen;
            add.Show();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Moviee_Show : UserControl
    {
        public Moviee_Show()
        {
            InitializeComponent();
        }
        private string TenPhim;
        private string idPhim;
        private string TheLoai;
        private string ThoiLuong;
        private string Poster;
        private string Demo;
        private string Ngaykhoichieu;
        private string Quocgia;
        private string Daodien;
        private string Dienvien;
        private string Mota;      
        private Image Pic;

        public Image PIC {
            get { return Pic; }
            set { Pic = value; pictureBox1.Image = value; }
        }
      
        
        public string TENPHIM {
            get { return TenPhim; }
            set { TenPhim = value; tp.Text = value; }
        }
        public string IDPHIM {
            get { return idPhim; }
            set { idPhim = value; id.Text = value; }
        }
        public string THELOAI {
            get { return TheLoai; }
            set { TheLoai = value; tl.Text = value; }
        }
        public string THOILUONG {
            get { return ThoiLuong; }
            set { ThoiLuong = value; thl.Text = value; }
        }
        public string POSTER {
            get { return Poster; }
            set { Poster = value; posterr.Text = value; }
        }
        public string DEMO {
            get { return Demo; }
            set { Demo = value; demoo.Text = value; }
        }
        public string NGAYKHOICHIEU {
            get { return Ngaykhoichieu; }
            set { Ngaykhoichieu = value; nkc.Text = value; }
        }
        public string QUOCGIA {
            get { return Quocgia; }
            set { Quocgia = value; qg.Text = value; }
        }
        public string DAODIEN {
            get { return Daodien; }
            set { Daodien = value; dd.Text = value; }
        }
        public string DIENVIEN {
            get { return Dienvien; }
            set { Dienvien = value; dv.Text = value; }
        }
        public string MOTA {
            get { return Mota; }
            set { Mota = value; richTextBox1.Text = value; }
        }
        
        private void bunifuTextBox15_TextChanged(object sender, EventArgs e)
        {
             
    }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            string sql = "DELETE FROM MOVIE  WHERE IDPHIM= '" + id.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();
                this.Hide();
                MessageBox.Show("Xóa phim thành công.");

                while (dbr.Read())

                {

                }

            }

            catch

            {
                

                MessageBox.Show("Không thể xóa phim này vì vẫn còn suất chiếu.");

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");     
            string sql = "UPDATE MOVIE SET TENPHIM= N'" + tp.Text + "',THELOAI= N'" + tl.Text + "',THOILUONG= N'" + thl.Text + "',POSTER='" + posterr.Text + "',DEMO='" + demoo.Text + "',NGAYKHOICHIEU= N'" + nkc.Text + "',QUOCGIA= N'" + qg.Text + "',DAODIEN= N'" + dd.Text + "',DIENVIEN= N'" + dv.Text + "',MOTA= N'" + richTextBox1.Text + "' WHERE IDPHIM= '" + id.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            Con.Open();
            dbr = cmd.ExecuteReader();
            MessageBox.Show(" Thay đổi thông tin thành công.");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Moviee_Show_Click(object sender, EventArgs e)
        {

        }
    }
}

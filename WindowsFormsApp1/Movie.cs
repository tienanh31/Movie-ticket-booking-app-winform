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
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        public class Luu
            {
            public static string IDSUATCHIEU;
            public static string RAP;
            public static string PHONG;
            public static string TEN;
            public static string TIME;
            public static string POSTER;

        }
        string _url;
        public string VideoID {
            get {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_url);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
                public void  Getdata()
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SHOW.NGAYCHIEU FROM SHOW,MOVIE WHERE MOVIE.IDPHIM=SHOW.IDPHIM AND MOVIE.TENPHIM = N'" + MoreMovie.LuuTen.Ten + "'", Con);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable table = new DataTable();
            data.Fill(table);
           comboBox1.DataSource = table;
            comboBox1.DisplayMember = "SHOW";
            comboBox1.ValueMember = "NGAYCHIEU";
        }
       
        public void Getdata2()
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SHOW.IDPHONG FROM SHOW,MOVIE WHERE MOVIE.IDPHIM=SHOW.IDPHIM AND MOVIE.TENPHIM = N'" + MoreMovie.LuuTen.Ten + "' AND NGAYCHIEU='" + comboBox1.Text + "'" , Con);
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = cmd;
            DataTable table = new DataTable();
            data.Fill(table);
            rjComboBox2.DataSource = table;
            rjComboBox2.DisplayMember = "SHOW";
            rjComboBox2.ValueMember = "IDPHONG";
        }
        public void GetDATA()
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IDSUATCHIEU,RAP,IDPHONG FROM SHOW WHERE NGAYCHIEU = N'" + comboBox1.Text + "'", Con);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                Luu.IDSUATCHIEU = data.GetValue(0).ToString();
                Luu.RAP = data.GetValue(1).ToString();
                Luu.PHONG = data.GetValue(2).ToString();
            }
        
        
               
            
        }
                private void Movie_Load(object sender, EventArgs e)
        {

                Getdata();        

            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
           Con.Open();
          SqlCommand cmd = new SqlCommand("SELECT MOVIE.TENPHIM,MOVIE.QUOCGIA,MOVIE.THELOAI,MOVIE.DIENVIEN,MOVIE.DAODIEN,MOVIE.NGAYKHOICHIEU,MOVIE.MOTA,MOVIE.THOILUONG,MOVIE.DEMO, MOVIE.POSTER FROM MOVIE,SHOW WHERE MOVIE.IDPHIM=SHOW.IDPHIM AND MOVIE.TENPHIM = N'" + MoreMovie.LuuTen.Ten + "'", Con);
           SqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {   
                tv.Text = data.GetValue(0).ToString();
                qg.Text = data.GetValue(1).ToString();
                tl.Text = data.GetValue(2).ToString();
                dv.Text = data.GetValue(3).ToString();
                dd.Text = data.GetValue(4).ToString();
                kc.Text = data.GetValue(5).ToString();
                textBox1.Text = data.GetValue(6).ToString();
                thl.Text = data.GetValue(7).ToString();
                _url = data.GetValue(8).ToString();
                Luu.POSTER = data.GetValue(9).ToString();
            }
             
            webBrowser1.DocumentText = String.Format("<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>", VideoID);
            Luu.TEN= tv.Text;
       }

        private void bunifuVSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ScrollEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    GetDATA();
        //    if(Luu.RAP=="2D")
        //    {
        //        _2DD T2D = new _2DD(Luu.IDSUATCHIEU);
        //        T2D.Show();
        //    }
        //   else if (Luu.RAP == "4DX")
        //    {
        //        _3DD T4DX = new _3DD(Luu.IDSUATCHIEU);
        //        T4DX.Show();
        //    }
        //   else if (Luu.RAP == "COUPLE")
        //    {
        //        Couple2D CP = new Couple2D(Luu.IDSUATCHIEU);
        //        CP.Show();
        //    }    
        //}

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Getdata2();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            GetDATA();
            Luu.TIME = comboBox1.Text;
            if (Luu.RAP == "2D")
            {
                _2DD T2D = new _2DD(Luu.IDSUATCHIEU);
                T2D.StartPosition = FormStartPosition.CenterScreen;
                T2D.Show();
            }
            else if (Luu.RAP == "4DX")
            {
                _3DD T4DX = new _3DD(Luu.IDSUATCHIEU);
                T4DX.StartPosition = FormStartPosition.CenterScreen;

                T4DX.Show();
            }
            else if (Luu.RAP == "COUPLE")
            {
                Couple2D CP = new Couple2D(Luu.IDSUATCHIEU);
                CP.StartPosition = FormStartPosition.CenterScreen;

                CP.Show();
            }
        }

        private void rjComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rjComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getdata2();
        }
    }
}

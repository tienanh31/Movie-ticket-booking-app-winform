using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class MoreMovie : Form
    {  
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data; 
        public PictureBox pic = new PictureBox();
        public Label lab = new Label();
        public Movie_Item item = new Movie_Item();
        public class LuuTen
        {
            static public string Ten;
        }    
            public MoreMovie()
        {  
            InitializeComponent();
        
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";



        }
        private void MoreMovie_Load(object sender, EventArgs e)
        {
            
            GetData();
           

        }
        public void Click_1(object sender, EventArgs e)
        { 
                LuuTen.Ten = ((Movie_Item)sender).Tag.ToString();
                Form movie = new Movie();
                movie.ShowDialog();
            
        }
        public void Click_2(object sender, EventArgs e)
        {
            
                MessageBox.Show("Bạn cần đăng nhập trước đã.");
            
        }
        public void GetData()
        {
           flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT POSTER,TENPHIM FROM MOVIE WHERE TENPHIM LIKE'"+textBox1.Texts+"%' ORDER  BY TENPHIM",con);
            data = cmd.ExecuteReader();

            while (data.Read())
            { 
                Form a2 = new _2DD();
                item = new Movie_Item();         
                item.Tag= data["TENPHIM"].ToString(); 
                item.TENPHIM = data["TENPHIM"].ToString();             
                string req = "";
                req = data.GetValue(0).ToString();
                var request = WebRequest.Create(req);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {

                   
                    item.Margin = new Padding(45,5,5,20);
                    item.poster = Bitmap.FromStream(stream);
                    flowLayoutPanel1.Controls.Add(item);
                    if (Login.LuuThongTin.ten.Trim() == "")
                    {
                        item.Click += new EventHandler(Click_2);
                    }
                    else
                    item.Click += new EventHandler(Click_1);

                }

            }


            data.Close();
            con.Close();
        }
        
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void movie_Item1_Load(object sender, EventArgs e)
        {

        }
       

        private void movie_Item1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movie_Item1_Load_2(object sender, EventArgs e)
        {

        }
    }
}

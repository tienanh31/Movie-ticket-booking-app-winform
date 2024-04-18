using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public class LuuTen
        {
            static public string Ten;
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
       
        public Movie_Item item = new Movie_Item();



    
        private void Home_Load(object sender, EventArgs e)
        {
                
            timer1.Interval = 2000;
            timer1.Start();

            pictureBox1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox1.Visible = false;
            GetData();
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
            }
        }
        public void Click_1(object sender, EventArgs e)
        {
            LuuTen.Ten = ((Movie_Item)sender).Tag.ToString();

            Form movie = new Movie();
            movie.ShowDialog();
        }
        

        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
        
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
            con.Open();
            cmd = new SqlCommand("SELECT POSTER,TENPHIM FROM MOVIE", con);
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                item = new Movie_Item();
                item.Tag = data["TENPHIM"].ToString();
                item.TENPHIM = data["TENPHIM"].ToString();
                string req = "";
                req = data.GetValue(0).ToString();
                var request = WebRequest.Create(req);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    item.Margin = new Padding(45, 5, 5, 20);
                    item.poster = Bitmap.FromStream(stream);
                    flowLayoutPanel1.Controls.Add(item);
                    item.Click += new EventHandler(Click_1);

                }

            }
            data.Close();
            con.Close();        
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
         

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }
    }
}

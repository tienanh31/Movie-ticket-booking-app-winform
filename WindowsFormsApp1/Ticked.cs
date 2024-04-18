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
using KimtToo.VisualReactive;
using System.Net;
namespace WindowsFormsApp1
{
    public partial class Ticked : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public TICKETT item = new TICKETT();

        public Ticked()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Ticked_Load(object sender, EventArgs e)
        {
            GetData();

        }
        public void GetData()
        {
            flowLayoutPanel1.Controls.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT POSTER,ID,GHEDAT,TONGTIEN,PHIM,PHONG,NGAYCHIEU,NGUOIDAT,PHIM FROM TICKET WHERE IDNGUOIDAT='"+Login.LuuThongTin.ID+"'", con);


            data = cmd.ExecuteReader();
            while (data.Read())
            {
                while (data.Read())
                {
                    item = new TICKETT();
                    
                    item.IDVE = data["ID"].ToString();
                    item.PHONG = data["PHONG"].ToString();
                    item.GHE = data["GHEDAT"].ToString();
                    item.TONGTIEN = data["TONGTIEN"].ToString();
                    item.PHIM = data["PHIM"].ToString();
                    item.THOIGIAN = data["NGAYCHIEU"].ToString();
                    item.NGUOIDAT = data["NGUOIDAT"].ToString();
                    item.PHIM = data["PHIM"].ToString();
                    flowLayoutPanel1.Controls.Add(item);
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
            }
            con.Close();
            data.Close();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

          
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tickett1_Load(object sender, EventArgs e)
        {

        }

        private void tickett2_Load(object sender, EventArgs e)
        {

        }

        private void tickett1_Load_1(object sender, EventArgs e)
        {
            GetData();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tickett1_Load_2(object sender, EventArgs e)
        {

        }

        private void tickett1_Load_3(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class _3DD : Form
    {
        List<SeatButton> seatButtons = new List<SeatButton>();

        public _3DD()
        {
            InitializeComponent();
        }
        string suatchieu;
        public _3DD(string suatchieu)
        {
            this.suatchieu = suatchieu;
            InitializeComponent();
        }

        private void initListSeat(List<SeatButton> seatButtons)
        {  
            seatButtons.Add((SeatButton)a1);
            seatButtons.Add((SeatButton)a2);
            seatButtons.Add((SeatButton)a3);
            seatButtons.Add((SeatButton)a4);
            seatButtons.Add((SeatButton)a5);
            seatButtons.Add((SeatButton)a6);
            seatButtons.Add((SeatButton)a7);
            seatButtons.Add((SeatButton)b1);
            seatButtons.Add((SeatButton)b2);
            seatButtons.Add((SeatButton)b3);
            seatButtons.Add((SeatButton)b4);
            seatButtons.Add((SeatButton)b5);
            seatButtons.Add((SeatButton)b6);
            seatButtons.Add((SeatButton)b7);
            seatButtons.Add((SeatButton)c1);
            seatButtons.Add((SeatButton)c2);
            seatButtons.Add((SeatButton)c3);
            seatButtons.Add((SeatButton)c4);
            seatButtons.Add((SeatButton)c5);
            seatButtons.Add((SeatButton)c6);
            seatButtons.Add((SeatButton)c7);
            seatButtons.Add((SeatButton)d1);
            seatButtons.Add((SeatButton)d2);
            seatButtons.Add((SeatButton)d3);
            seatButtons.Add((SeatButton)d4);
            seatButtons.Add((SeatButton)d5);
            seatButtons.Add((SeatButton)d6);
            seatButtons.Add((SeatButton)d7);
            seatButtons.Add((SeatButton)e1);
            seatButtons.Add((SeatButton)e2);
            seatButtons.Add((SeatButton)e3);
            seatButtons.Add((SeatButton)e4);
            seatButtons.Add((SeatButton)e5);
            seatButtons.Add((SeatButton)e6);
            seatButtons.Add((SeatButton)e7);
            seatButtons.Add((SeatButton)f1);
            seatButtons.Add((SeatButton)f3);
            seatButtons.Add((SeatButton)f5);
            seatButtons.Add((SeatButton)f7);
        }

        
       

        private void b7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
           int totalPrice = 0;
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {

                    totalPrice += 250000;
                }
            }
            textBox1.Texts = totalPrice.ToString();
            textBox1.Texts = string.Format("{0:0,0 vnđ}", totalPrice);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatButtons.Count; i++)
            {

                if (seatButtons[i].BackColor == Color.Blue)
                    seatButtons[i].BackColor = Color.Brown;

            }
            textBox1.Texts = "0";
        }
          
         private void _3DD_Load(object sender, EventArgs e)
        {
            initListSeat(seatButtons);

            for (int i = 0; i<seatButtons.Count; i++)
            {
                SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

        Con.Open();

                string sql = " SELECT VITRI,TINHTRANG,IDSUATCHIEU FROM STATUSS WHERE VITRI='" + seatButtons[i].Text + "' AND TINHTRANG='1' AND IDSUATCHIEU='"+suatchieu+"'";
        SqlCommand cmd = new SqlCommand(sql, Con);
        SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    seatButtons[i].BackColor = Color.White;

                }
}
        }

        private void button67_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatButtons.Count; i++)
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    seatButtons[i].BackColor = Color.White;
                }
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label10.Text = textBox1.Texts;
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void label15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


                    string sql = "INSERT INTO STATUSS(VITRI,TINHTRANG,IDSUATCHIEU) values ('" + seatButtons[i].Text + "','" + 1 + "','" + suatchieu + "')";
                    SqlCommand cmd = new SqlCommand(sql, Con);

                    SqlDataReader dbr;
                    Con.Open();
                    dbr = cmd.ExecuteReader();

                }
            }
            string GHE = "";

            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    GHE += seatButtons[i].Text;
                }
            }
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {

                    SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
                    string sql = "insert into TICKET(NGUOIDAT,IDNGUOIDAT,GHEDAT,TONGTIEN,PHIM,PHONG,NGAYCHIEU,POSTER) values (N'" + bunifuTextBox1.Text + "','" + Login.LuuThongTin.ID + "','" + GHE + "', N'" + textBox1.Texts + "', N'" + Movie.Luu.TEN + "','" + Movie.Luu.PHONG + "','" + Movie.Luu.TIME + "','" + Movie.Luu.POSTER + "')";
                    SqlCommand cmd = new SqlCommand(sql, Con);
                    SqlDataReader dbr;
                    Con.Open();
                    dbr = cmd.ExecuteReader();
                }
            }
            MessageBox.Show("Thanh toán thành công, cảm ơn bạn.");

            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    seatButtons[i].BackColor = Color.Green;
                }
            }
            panel2.Visible = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi mã OTP về máy, vui lòng check.");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}

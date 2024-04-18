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
    public partial class Couple2D : Form
    {
        List<SeatButton> seatButtons = new List<SeatButton>();

        public Couple2D()
        {
            InitializeComponent();
        }
        string suatchieu;
        public Couple2D(string suatchieu)
        {
            this.suatchieu = suatchieu;
            InitializeComponent();
        }
        private void initListSeat(List<SeatButton> seatButtons)
        {
            seatButtons.Add((SeatButton)f1);
            seatButtons.Add((SeatButton)f3);
            seatButtons.Add((SeatButton)f5);
            seatButtons.Add((SeatButton)f7);
            seatButtons.Add((SeatButton)f9);
            seatButtons.Add((SeatButton)f11);
            seatButtons.Add((SeatButton)f13);
            seatButtons.Add((SeatButton)f15);
            seatButtons.Add((SeatButton)f17);
            seatButtons.Add((SeatButton)f19);
            seatButtons.Add((SeatButton)f21);
            seatButtons.Add((SeatButton)f23);
            seatButtons.Add((SeatButton)f25);
            seatButtons.Add((SeatButton)f27);
            seatButtons.Add((SeatButton)f29);
            seatButtons.Add((SeatButton)f31);
            seatButtons.Add((SeatButton)f33);
            seatButtons.Add((SeatButton)f35);
            seatButtons.Add((SeatButton)f37);
            seatButtons.Add((SeatButton)f39);
            seatButtons.Add((SeatButton)f41);
            seatButtons.Add((SeatButton)f43);
            seatButtons.Add((SeatButton)f45);
            seatButtons.Add((SeatButton)f47);
          
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void f45_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int totalPrice = 0;
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    if (i >= 0 && i <= 23)
                        totalPrice += 160000;

                }
            }
           
            textBox1.Texts = totalPrice.ToString();
            textBox1.Texts = string.Format("{0:0,0 vnđ}", totalPrice);


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < seatButtons.Count; i++)
            {

                if (seatButtons[i].BackColor == Color.Blue)
                    seatButtons[i].BackColor = Color.Plum;

            }
            textBox1.Texts = "0";
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
            panel1.Visible = false;
            panel2.Visible = true;
            label10.Text = textBox1.Texts;
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
                    GHE += seatButtons[i].Text+" " ;
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
        private void Couple2D_Load(object sender, EventArgs e)
        {
            initListSeat(seatButtons);

            for (int i = 0; i < seatButtons.Count; i++)
            {
                SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

                Con.Open();

                string sql = " SELECT VITRI,TINHTRANG,IDSUATCHIEU FROM STATUSS WHERE VITRI='" + seatButtons[i].Text + "' AND TINHTRANG='1' AND IDSUATCHIEU='" + suatchieu + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    seatButtons[i].BackColor = Color.White;

                }

            }
        
            }
        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi mã OTP về máy, vui lòng check.");

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}

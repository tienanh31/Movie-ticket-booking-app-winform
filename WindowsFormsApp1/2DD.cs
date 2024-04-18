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
using Bunifu;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class _2DD : Form

    {

        List<SeatButton> seatButtons = new List<SeatButton>();
        public _2DD()
        {
            InitializeComponent();
        }


        public string suatchieu;
        public _2DD(string idsuatchieu)
        {
            this.suatchieu = idsuatchieu;
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
            seatButtons.Add((SeatButton)a8);
            seatButtons.Add((SeatButton)a9);
            seatButtons.Add((SeatButton)a10);
            seatButtons.Add((SeatButton)a11);
            seatButtons.Add((SeatButton)b1);
            seatButtons.Add((SeatButton)b2);
            seatButtons.Add((SeatButton)b3);
            seatButtons.Add((SeatButton)b4);
            seatButtons.Add((SeatButton)b5);
            seatButtons.Add((SeatButton)b6);
            seatButtons.Add((SeatButton)b7);
            seatButtons.Add((SeatButton)b8);
            seatButtons.Add((SeatButton)b9);
            seatButtons.Add((SeatButton)b10);
            seatButtons.Add((SeatButton)b11);
            seatButtons.Add((SeatButton)c1);
            seatButtons.Add((SeatButton)c2);
            seatButtons.Add((SeatButton)c3);
            seatButtons.Add((SeatButton)c4);
            seatButtons.Add((SeatButton)c5);
            seatButtons.Add((SeatButton)c6);
            seatButtons.Add((SeatButton)c7);
            seatButtons.Add((SeatButton)c8);
            seatButtons.Add((SeatButton)c9);
            seatButtons.Add((SeatButton)c10);
            seatButtons.Add((SeatButton)c11);
            seatButtons.Add((SeatButton)d1);
            seatButtons.Add((SeatButton)d2);
            seatButtons.Add((SeatButton)d3);
            seatButtons.Add((SeatButton)d4);
            seatButtons.Add((SeatButton)d5);
            seatButtons.Add((SeatButton)d6);
            seatButtons.Add((SeatButton)d7);
            seatButtons.Add((SeatButton)d8);
            seatButtons.Add((SeatButton)d9);
            seatButtons.Add((SeatButton)d10);
            seatButtons.Add((SeatButton)d11);
            seatButtons.Add((SeatButton)e1);
            seatButtons.Add((SeatButton)e2);
            seatButtons.Add((SeatButton)e3);
            seatButtons.Add((SeatButton)e4);
            seatButtons.Add((SeatButton)e5);
            seatButtons.Add((SeatButton)e6);
            seatButtons.Add((SeatButton)e7);
            seatButtons.Add((SeatButton)e8);
            seatButtons.Add((SeatButton)e9);
            seatButtons.Add((SeatButton)e10);
            seatButtons.Add((SeatButton)e11);
            seatButtons.Add((SeatButton)f1);
            seatButtons.Add((SeatButton)f3);
            seatButtons.Add((SeatButton)f5);
            seatButtons.Add((SeatButton)f7);
        }




        private void a1_Click(object sender, EventArgs e)
        {





        }

        private void f7_Click(object sender, EventArgs e)
        {

        }

        private void a4_Click(object sender, EventArgs e)
        {

        }

        private void c9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            int totalPrice = 0;
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            string a="";
            string sql = "SELECT IDNGUOIDAT,COUNT(IDNGUOIDAT) FROM TICKET, SIGNIN WHERE IDNGUOIDAT = SIGNIN.ID AND IDNGUOIDAT='" + Login.LuuThongTin.ID + "' GROUP BY IDNGUOIDAT  HAVING(COUNT(IDNGUOIDAT)>=10)";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader data;
            Con.Open();
            data = cmd.ExecuteReader();
            while (data.Read())
            {
               a = data["COUNT(IDNGUOIDAT)"].ToString();
            }
            if (Convert.ToInt32(a) >= 10)
            {
                MessageBox.Show("Vì bạn đã đặt vé ở Rạp LeTter CinemA hơn 10 nên bạn được giảm 10.000vnđ cho các vé.");
                for (int i = 0; i < seatButtons.Count; i++)
                {



                    if (seatButtons[i].BackColor == Color.Blue && ((i >= 0 && i <= 23) || (i >= 31 && i <= 34) || (i >= 42 && i <= 45) || (i >= 53 && i <= 54)))
                        totalPrice += 35000;
                    else if (seatButtons[i].BackColor == Color.Blue && ((i >= 24 && i <= 30) || (i >= 35 && i <= 41) || (i >= 46 && i <= 52)))
                        totalPrice += 60000;
                    else if (seatButtons[i].BackColor == Color.Blue && ((i >= 55 && i <= 58)))
                        totalPrice += 100000;


                }

            }
            else
            {
                for (int i = 0; i < seatButtons.Count; i++)
                {



                    if (seatButtons[i].BackColor == Color.Blue && ((i >= 0 && i <= 23) || (i >= 31 && i <= 34) || (i >= 42 && i <= 45) || (i >= 53 && i <= 54)))
                        totalPrice += 45000;
                    else if (seatButtons[i].BackColor == Color.Blue && ((i >= 24 && i <= 30) || (i >= 35 && i <= 41) || (i >= 46 && i <= 52)))
                        totalPrice += 70000;
                    else if (seatButtons[i].BackColor == Color.Blue && ((i >= 55 && i <= 58)))
                        totalPrice += 110000;


                }
            }
            textBox1.Texts = totalPrice.ToString();
            textBox1.Texts = string.Format("{0:0,0 vnđ}", totalPrice);

            //for (int i = 0; i < seatButtons.Count; i++)
            //{
            //    if (seatButtons[i].BackColor == Color.Blue)
            //    {
            //        SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            //        string sql = "insert into STATUSS(VITRI,TINHTRANG,IDSUATCHIEU) values ('" + seatButtons[i].Text + "','" + 1 + "','" + suatchieu + "')";
            //        SqlCommand cmd = new SqlCommand(sql, Con);
            //        SqlDataReader dbr;
            //        Con.Open();
            //        dbr = cmd.ExecuteReader();

            //    }
            // }

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

        private void f5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            label10.Text = textBox1.Texts;
        //    string GHE = "";
        //    for (int i = 0; i < seatButtons.Count; i++)
        //    {
        //        if (seatButtons[i].BackColor == Color.Blue)
        //        {
        //            seatButtons[i].BackColor = Color.Green;
        //        }
        //    }
        //    for (int i = 0; i < seatButtons.Count; i++)
        //    {
        //        if (seatButtons[i].BackColor == Color.Blue)
        //        {
        //            GHE += seatButtons[i];
        //        }
        //    }

        //    for (int i = 0; i < seatButtons.Count; i++)
        //    {
        //        if (seatButtons[i].BackColor == Color.Blue)
        //        {

        //            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
        //            string sql = "insert into TICKET(NGUOIDAT,IDNGUOIDAT,IDSUATCHIEU,GHEDAT,TONGTIEN,PHIM,PHONG,RAP,NGUOIDAT) values (N'" + bunifuTextBox1.Text + "','" + login.LuuThongTin.ID + "', N'" + Movie.Luu.IDSUATCHIEU + "','" + GHE + "', N'" + Movie.Luu.TEN + "','" + textBox1.Texts + "','" + Movie.Luu.PHONG + "','" + Movie.Luu.RAP + "','" + Movie.Luu.TIME + "')";
        //            SqlCommand cmd = new SqlCommand(sql, Con);
        //            SqlDataReader dbr;
        //            Con.Open();
        //            dbr = cmd.ExecuteReader();
        //        }
        //    }
         


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            



        }

        private void bunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
          

            //   bunifuCheckBox1.Checked = true;
            // bunifuCheckBox3.Checked = false;

            //bunifuCheckBox1.Checked = bunifuCheckBox3.Checked = false;

            //bunifuCheckBox2.Checked = true;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã gửi mã OTP về máy, vui lòng check.");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


                    string sql = "insert into STATUSS(VITRI,TINHTRANG,IDSUATCHIEU) values ('" + seatButtons[i].Text + "','" + 1 + "','" + suatchieu + "')";
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
                    string sql = "insert into TICKET(NGUOIDAT,IDNGUOIDAT,GHEDAT,TONGTIEN,PHIM,PHONG,NGAYCHIEU,POSTER) values (N'" + bunifuTextBox1.Text + "','" + Login.LuuThongTin.ID + "','" + GHE + "', N'" + textBox1.Texts + "', N'" + Movie.Luu.TEN + "','" + Movie.Luu.PHONG + "','" + Movie.Luu.TIME + "','"+Movie.Luu.POSTER+"')";
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
      
        private void _2DD_Load(object sender, EventArgs e)
        {
           
                initListSeat(seatButtons);
            for (int i = 0; i < seatButtons.Count; i++)
            {
                if (seatButtons[i].BackColor == Color.Blue)
                {
                    seatButtons[i].BackColor = Color.White;
                }    
            }
            for (int i = 0; i < seatButtons.Count; i++)
            {
                
              
                SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");                 
                Con.Open();

                string sql = " select VITRI,TINHTRANG,IDSUATCHIEU from STATUSS where VITRI='" + seatButtons[i].Text + "' and TINHTRANG='1' and IDSUATCHIEU='" + suatchieu + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    seatButtons[i].BackColor = Color.White;

                }
            }
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatButtons.Count; i++)
            {

                if (seatButtons[i].BackColor == Color.Blue && ((i >= 0 && i <= 23) || (i >= 31 && i <= 34) || (i >= 42 && i <= 45) || (i >= 53 && i <= 54)))
                    seatButtons[i].BackColor = Color.Orange;
                 if (seatButtons[i].BackColor == Color.Blue && ((i >= 55 && i <= 58)))
                    seatButtons[i].BackColor = Color.Plum;
                 if (seatButtons[i].BackColor == Color.Blue && ((i >= 24 && i <= 30) || (i >= 35 && i <= 41) || (i >= 46 && i <= 52)))
                    seatButtons[i].BackColor = Color.Brown;

            }
            textBox1.Texts = "0";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}


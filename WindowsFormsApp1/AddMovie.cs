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
using System.IO;
namespace WindowsFormsApp1
{

    public partial class AddMovie : Form
    {


        public AddMovie()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextsChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            button10.IdleBorderRadius = 10;

            this.Loadcombobox();

        }
        public void Loadcombobox()
        {
           
        }
        public class Luu
        {
            static public string url;
            static public string poster;
            static public string idphim;

        }


        private void url_TextsChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextsChanged(object sender, EventArgs e)
        {

        }

   

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       

       

        private void button10_Click_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            string sql = "insert into MOVIE(IDPHIM,NGAYKHOICHIEU,QUOCGIA,DAODIEN,DIENVIEN,MOTA,TENPHIM,THELOAI,THOILUONG,DEMO,POSTER) values( '" + this.rjTextBox1.Texts + "', N'" + this.kc.Texts + "', N'" + this.qg.Texts + "', N'" + this.dd.Texts + "', N'" + this.dv.Texts + "', N'" + this.textBox7.Text + "', N'" + this.textBox2.Texts + "', N'" + this.textBox3.Texts + "', N'" + this.textBox4.Texts + "', N'" + this.url.Texts + "', N'" + this.poster.Texts + "')";
            
            SqlCommand cmd = new SqlCommand(sql, Con);          
            SqlDataReader dbr;          
            if (rjTextBox1.Texts.Trim() == "") MessageBox.Show("Bạn chưa nhập ID Phim.");
            else if (poster.Texts.Trim() == "") MessageBox.Show("Bạn chưa cho ảnh Poster Phim.");
            else if(url.Texts.Trim() == "") MessageBox.Show("Bạn chưa cho video Trailer Phim.");
            else

            {
                try

                {

                    Con.Open();

                    dbr = cmd.ExecuteReader();


                  AddShow add = new AddShow(rjTextBox1.Texts);

                    MessageBox.Show("Thêm phim thành công.");
                    this.Close();
                    add.StartPosition = FormStartPosition.CenterScreen;
                    add.Show();

                    while (dbr.Read())

                    {

                    }

                }

                catch (Exception es)

                {

                    MessageBox.Show(es.Message);

                }
                
            }
            Luu.url = url.Texts;
            Luu.poster = poster.Texts;
            this.textBox2.Texts = this.qg.Texts = this.dv.Texts = this.kc.Texts = this.dd.Texts = this.textBox2.Texts = this.textBox3.Texts = this.textBox4.Texts = this.textBox7.Text = this.url.Texts = this.poster.Texts = "";
            
        }

       
            


        
    

        private void textBox8__TextsChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

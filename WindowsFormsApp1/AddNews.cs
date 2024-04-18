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
    public partial class AddNews : Form
    {
        public AddNews()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            string sql = "insert into  NEWS(TIEUDE,POSTER,NOIDUNG) values( N'" +this.rjTextBox2.Texts+"', N'"+this.rjTextBox3.Texts+"',N'"+this.richTextBox1.Text+"')";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            if (rjTextBox2.Texts.Trim() == "") MessageBox.Show("Bạn chưa nhập Tiêu đề thông tin.");
            else if (rjTextBox3.Texts.Trim() == "") MessageBox.Show("Bạn chưa cho ảnh Poster thông tin.");
            else if (richTextBox1.Text.Trim() == "") MessageBox.Show("Bạn chưa cho nội dung thông tin.");
            else

            {
                try

                {

                    Con.Open();

                    dbr = cmd.ExecuteReader();



                    MessageBox.Show("Thêm thông tin thành công.");                 

                    while (dbr.Read())

                    {

                    }

                }

                catch (Exception es)

                {

                    MessageBox.Show(es.Message);

                }

            }

            this.rjTextBox2.Texts = this.rjTextBox3.Texts = this.richTextBox1.Text = "";
                }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

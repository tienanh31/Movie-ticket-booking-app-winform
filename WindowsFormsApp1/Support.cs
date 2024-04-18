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
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }


        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Họ Tên")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Họ Tên";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Gmail")
            {
                textBox2.Text = "";

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Gmail";


            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Số điện thoại")
            {
                textBox3.Text = "";

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Số điện thoại";

            }
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Nội dung")
            {
                richTextBox1.Text = "";

            }
        }

        
        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Nội dung";

            }

        }










        private void label4_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            string sql = "insert into SUPPORT(HOTEN,GMAIL,SDT,NOIDUNG) values( N'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', N'" + richTextBox1.Text + "')";

            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader dbr;

            if (textBox2.Text.Trim() == "Gmail"|| textBox2.Text.Trim() == "") MessageBox.Show("Bạn Vui lòng nhập đúng Gmail để bên mình tiện hỗ trợ.");
            else
            if (textBox3.Text.Trim() == ""|| textBox3.Text.Trim() =="Số điện thoại" ) MessageBox.Show("Bạn Vui lòng nhập đúng Số điện thoại để bên mình tiện hỗ trợ.");



            else

            {
                try

                {

                    Con.Open();

                    dbr = cmd.ExecuteReader();
                    //dbr1 = cmd1.ExecuteReader();
                    //dbr2 = cmd2.ExecuteReader();


                    MessageBox.Show("Bên mình sẽ sớm phản hồi bạn, bạn vui lòng kiểm tra hộp thư Gmail.");

                    while (dbr.Read())

                    {

                    }

                }

                catch (Exception es)

                {

                    MessageBox.Show(es.Message);

                }

            }
            textBox1.Text = textBox2.Text = textBox3.Text = richTextBox1.Text = "";
        }

        private void SuPportcs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    


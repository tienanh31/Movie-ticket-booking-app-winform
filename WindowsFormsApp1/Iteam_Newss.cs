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
    public partial class Iteam_Newss : UserControl
    {
        public Iteam_Newss()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string Tieude;
        private string Noidung;
        private string Poster;
        private string Id;

        public string ID
        {
            get { return Id; }
            set { Id = value; iddd.Text = value; }
        }

        public string POSTER
        {
            get { return Poster; }
            set { Poster = value; bunifuTextBox2.Text = value; }
        }

        public string TIEUDE
        {
            get { return Tieude; }
            set { Tieude = value; bunifuTextBox1.Text = value; }
        }

        public string NOIDUNG
        {
            get { return Noidung; }
            set { Noidung = value; richTextBox1.Text = value; }
        }
        private void Iteam_Newss_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            string sql = "DELETE FROM NEWS  WHERE ID= '" + iddd.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();
                this.Hide();
                MessageBox.Show("Xóa tin tức thành công.");

                while (dbr.Read())

                {

                }

            }
            catch(Exception es)

            {


                MessageBox.Show(es.Message);

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            string sql = "UPDATE  NEWS SET TIEUDE= N'" + bunifuTextBox1.Text + "',POSTER= N'" + bunifuTextBox2.Text + "',NOIDUNG= N'" + richTextBox1.Text + "' WHERE ID= '" + iddd.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            Con.Open();
            dbr = cmd.ExecuteReader();
            MessageBox.Show(" Thay đổi thông tin thành công.");
        }
    }
}

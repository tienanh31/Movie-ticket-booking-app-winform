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
    public partial class Mail : UserControl
    {
        public Mail()
        {
            InitializeComponent();
        }
        private string Id;
        public string ID
        {
            get { return Id; }
            set { Id = value; iddd.Text = value; }
        }
        private string Ten;
        public string TEN
        {
            get { return Ten; }
            set { Ten = value; tenn.Text = value; }
        }
        private string Gmail;
        public string GMAIL
        {
            get { return Gmail; }
            set { Gmail = value; gm.Text = value; }
        }
        private string Sdt;
        public string SDT
        {
            get { return Sdt; }
            set { Sdt = value; sdt.Text = value; }
        }
        private string Gopy;
        public string GOPY
        {
            get { return Gopy; }
            set { Gopy = value; gy.Text = value; }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            string sql = "DELETE FROM SUPPORT  WHERE iD= '" + iddd.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();
                this.Hide();
                MessageBox.Show("Xóa phản hồi thành công.");

                while (dbr.Read())

                {

                }

            }

            catch(Exception ex)

            {


                MessageBox.Show(ex.Message);

            }
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void gm_TextChanged(object sender, EventArgs e)
        {

        }

        private void gy_TextChanged(object sender, EventArgs e)
        {

        }
        public class Luu
        {
            static public string Gmail;
            static public string Ten;
            static public string Sdt;
        }
        private void label4_Click(object sender, EventArgs e)
        {   
            Luu.Gmail = this.gm.Text;
            Luu.Ten = this.tenn.Text;
            Luu.Sdt = this.sdt.Text;
            SendMail Smail = new SendMail();
            Smail.Show();
        }
    }
}

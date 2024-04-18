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
    public partial class AddShow : Form
    {
        public AddShow()
        {
            InitializeComponent();
        }
        public string IDPHIM;
        public AddShow(string idphim)
        {
            IDPHIM = idphim;
            InitializeComponent();
            rjTextBox1.Texts = IDPHIM;

        }
        private void AddShow_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        ////public void CHECK_AS()
        ////{
        ////    string CHECK1 = "";

        ////    SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
        ////    string sql1 = "SELECT COUNT(IDPHONG) AS '" + CHECK1 + "' FROM SHOW WHERE IDPHONG='" + this.comboBox2.Text + "' AND NGAYCHIEU='" + this.dateTimePicker1.Value.ToString("MM / dd / yyyy hh:mm") + "' AND Rap='" + this.comboBox1.Text + "'";
        ////    SqlCommand cmd1 = new SqlCommand(sql1, Con);

        ////    SqlDataReader dbr;

        ////    dbr = cmd1.ExecuteReader();
        ////    MessageBox.Show("Thêm suất chiếu thành công.");
        ////    while (dbr.Read())
        ////    {

        ////    }
        ////    if (CHECK1 != "0")

        ////        MessageBox.Show("Không thể thêm suất chiếu vì đã trùng thông tin.");
        ////}    
        private void button10_Click_1(object sender, EventArgs e)
        {  
            
              try

                {
                  SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

                Con.Open();
                string sql = "insert into Show(IDPHIM,IDPHONG,NGAYCHIEU,IDSUATCHIEU,RAP) values( '" + this.rjTextBox1.Texts + "','" + this.comboBox2.Text + "','" + this.dateTimePicker1.Value.ToString("MM / dd / yyyy hh:mm") + "','" + this.rjTextBox2.Texts + "','" + this.comboBox1.Text + "')";

                    SqlCommand cmd = new SqlCommand(sql, Con);
                    SqlDataReader dbr1;
                    dbr1 = cmd.ExecuteReader();
                    MessageBox.Show("Thêm suất chiếu thành công.");
                    while (dbr1.Read())

                    {

                    }
                }
                catch (Exception es)

                {

                    MessageBox.Show(es.Message);

                }
                this.comboBox1.Text = this.comboBox2.Text = this.rjTextBox2.Texts = "";
            
        }
    }
    
}

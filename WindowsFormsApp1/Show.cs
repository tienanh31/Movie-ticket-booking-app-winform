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
    public partial class Show : UserControl
    {
        public Show()
        {
            InitializeComponent();

        }
        

        
        public string Idp;
        public string IDPHIM {
            get { return Idp; }
            set { Idp = value; idpp.Text = value; }
        }
       
       
        public string Ids;
        public string IDSUAT {
            get { return Ids; }
            set { Ids = value; sc.Text = value; }
        }
        public string Phongchieu;
        public string PHONGCHIEU {
            get { return Phongchieu; }
            set { Phongchieu = value; pc.Texts = value; }
        }
        public string Rap;
        public string RAP {
            get { return Rap; }
            set { Rap = value; rc.Texts = value; }
        }
        public string Ngaychieu;
        public string NGAYCHIEU {
            get { return Ngaychieu; }
            set { Ngaychieu = value; nc.Text = value; }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Show_Load(object sender, EventArgs e)
        {
            rc.DropDownStyle = ComboBoxStyle.DropDownList;
            pc.DropDownStyle = ComboBoxStyle.DropDownList;

        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Del1()
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            string sql = "DELETE FROM STATUSS WHERE IDSUATCHIEU= '" + sc.Text + "'";          
            SqlCommand cmd = new SqlCommand(sql, Con);      
            SqlDataReader dbr;
            Con.Open();
            dbr = cmd.ExecuteReader();      
           
        }
        private void Del2()
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
           
            string sql = "DELETE FROM SHOW  WHERE IDSUATCHIEU= '" + sc.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            Con.Open();
            dbr = cmd.ExecuteReader();
     

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Del1();
            Del2();
            
            this.Hide();
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            string sql = "UPDATE SHOW SET Rap='" + rc.Texts + "',IDPHONG='" + pc.Texts + "',NGAYCHIEU='" + nc.Text + "' WHERE IDSUATCHIEU='" + sc.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader dbr;
            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();
                while (dbr.Read())

                {

                }

                MessageBox.Show(" Thay đổi thông tin thành công.");
            }
            catch

            {

                MessageBox.Show("Thông tin về suất chiếu này đã trùng với trước đó, vui lòng kiểm tra lại.");

            }
        }

        private void nc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

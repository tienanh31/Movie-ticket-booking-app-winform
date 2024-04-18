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
using System.Net;
namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public Newss news = new Newss();

        public Main()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            panel2.BackColor = Color.FromArgb(125, Color.Black);
            panel3.BackColor = Color.FromArgb(125, Color.Black);
            panel4.BackColor = Color.FromArgb(125, Color.Black);
            panel5.BackColor = Color.FromArgb(125, Color.Black);
            flowLayoutPanel1.BackColor = Color.FromArgb(125, Color.Black);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadFormCustomer(object Form)
        {

           
            Form f = Form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 20;
            f.Top = 20;
            f.BringToFront();
            f.Show();
            panel5.Controls.Add(f);
            f.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            con.Open();
            cmd = new SqlCommand("SELECT POSTER,TIEUDE,NOIDUNG  FROM NEWS", con);
            data = cmd.ExecuteReader();

            while (data.Read())
            {

                news = new Newss();
                news.TIEUDE = data["TIEUDE"].ToString();
                news.NOIDUNG = data["NOIDUNG"].ToString();
                string req = "";
                req = data.GetValue(0).ToString();
                var request = WebRequest.Create(req);
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {


                    news.PIC = Bitmap.FromStream(stream);
                    flowLayoutPanel1.Controls.Add(news);
                    

                }

            }
        }
            private void label1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }
         static public  Sign_in sig=new Sign_in();
        private void label2_Click(object sender, EventArgs e)
        {
            
            sig.ShowDialog();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = true;
            //panel5.Visible = false;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            //  panel5.Visible = false;

            flowLayoutPanel1.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            //panel5.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // panel5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Support sp = new Support();
            sp.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = true;

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = panel3.Visible = panel4.Visible = false;
            panel5.Visible = true;
            LoadFormCustomer(new Home());
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            panel2.Visible = panel3.Visible = panel4.Visible = panel5.Visible = false;
            Support sp = new Support();
            sp.ShowDialog();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;

            panel3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newss1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RE_PASSWORD : Form
    {
        public RE_PASSWORD()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void label3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập Gmail đã đăng ký.");
            }    
            else
            {
                string query = "SELECT *FROM SIGNIN WHERE GMAIL='" + textBox1.Text + "'";
                if(modify.TK(query).Count!=0)       
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = " Mặt khẩu: " + modify.TK(query)[0].Mk;
                }    
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = " Gmail này chưa đăng ký.";
                    textBox1.Focus();
                }    
            }    
        }

        private void RE_PASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

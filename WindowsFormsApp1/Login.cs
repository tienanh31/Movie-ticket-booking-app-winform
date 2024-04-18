using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label7.Height = 2;
            label8.Height = 2;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       public class LuuThongTin
        {
            static public string ten="Đang cập nhật";
          static public string ID;
        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            Sign_in form = new Sign_in();
            form.Show();
            
        }
        /* public static string Base64Encode(string plainText)
         {
             var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
             return System.Convert.ToBase64String(plainTextBytes);
         }
         public static string MD5Hash(string input)
         {
             StringBuilder hash = new StringBuilder();
             MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
             byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

             for (int i = 0; i < bytes.Length; i++)
             {
                 hash.Append(bytes[i].ToString("x2"));
             }
             return hash.ToString();
         }*/
       
        public static string Encrypt(string text)
        {
            var data = Encoding.UTF8.GetBytes(text);
            string key = "hello";
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
                using (var tripDes = new TripleDESCryptoServiceProvider { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var transform = tripDes.CreateEncryptor();
                    var results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            try
            {

                Con.Open();
                string tk = textBox1.Text;
                string mk = textBox2.Text;
                string passEncode = Encrypt(mk);

                string sql = "select *from SIGNIN where TK='" + tk + "'and MK='" + passEncode + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    LuuThongTin.ten = textBox1.Text;
                    LuuThongTin.ID = data["ID"].ToString();
                    MessageBox.Show(" Đăng nhập thành công.");
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Hide();
                }
                else MessageBox.Show(" Đăng nhập không thành công, lỗi mật khẩu hoặc tài khoản.");
            }
            catch (Exception)
            {

                MessageBox.Show(" Lỗi kết nối. ");
            }

        }
        public void LoadFormMovie(object Form)
        {
           
        }
        private void label4_Click(object sender, EventArgs e)
        {
           
            Sign_in sig = new Sign_in();
            sig.StartPosition = FormStartPosition.CenterScreen;
            sig.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RE_PASSWORD re =new RE_PASSWORD();
            re.StartPosition = FormStartPosition.CenterParent;
            re.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Tài khoản")
            {
                textBox1.Text = "";
            }    
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tài khoản";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mặt khẩu")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Mặt khẩu";
                textBox2.UseSystemPasswordChar = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

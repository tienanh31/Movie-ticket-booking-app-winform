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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        string hash = "hello";
      public string Decode(string code) {
         byte[] data = Convert.FromBase64String(code);
          using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
          {
               byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Decrypt data by hash key
               using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
               {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                  byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                   return UTF8Encoding.UTF8.GetString(results);
                  
               }
            }
      }
        private void Form1_Load(object sender, EventArgs e)
        {
                


            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT HOTEN,GIOITINH,NGAYSINH,SDT,GMAIL,TK,MK FROM SIGNIN WHERE TK='" + Login.LuuThongTin.ten + "'", Con);
            SqlDataReader data = cmd.ExecuteReader();
            while (data.Read() == true)
            {
                textBox1.Texts = data.GetValue(0).ToString();
                comboBox1.Texts = data.GetValue(1).ToString();
                dateTimePicker1.Text = data.GetValue(2).ToString();
                textBox4.Texts = data.GetValue(3).ToString();
                textBox5.Texts = data.GetValue(4).ToString();
                textBox6.Text = data.GetValue(5).ToString();
                textBox2.Texts = Decode(data.GetValue(6).ToString());


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            string sql = "update SIGNIN set GMAIL='" + textBox5.Texts + "', HOTEN = N'" + this.textBox1.Texts + "', GIOITINH='" + this.comboBox1.Texts + "', NGAYSINH='" + this.dateTimePicker1.Value.ToString() + "',SDT='" + this.textBox4.Texts + "', TK='" + this.textBox6.Text + "', MK='" + this.textBox2.Texts + "'  WHERE TK='" + Login.LuuThongTin.ten + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader dbr;

            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();

                MessageBox.Show("Cập nhật thông tin thành công.");

                while (dbr.Read())

                {

                }

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void button8_Click_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");


            string sql = "update SIGNIN set GMAIL='" + textBox5.Texts + "', HOTEN = N'" + this.textBox1.Texts + "', GIOITINH='" + this.comboBox1.Texts + "', NGAYSINH='" + this.dateTimePicker1.Value.ToString() + "',SDT='" + this.textBox4.Texts + "', TK='" + this.textBox6.Text + "', MK='" + Encrypt(this.textBox2.Texts) + "'  WHERE TK='" + Login.LuuThongTin.ten + "'";

            SqlCommand cmd = new SqlCommand(sql, Con);

            SqlDataReader dbr;

            try

            {

                Con.Open();

                dbr = cmd.ExecuteReader();

                MessageBox.Show("Cập nhật thông tin thành công.");

                while (dbr.Read())

                {

                }

            }
            catch (Exception es)

            {

                MessageBox.Show(es.Message);

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

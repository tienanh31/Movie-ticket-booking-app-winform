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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
            
        }
        private void Sign_in_Load(object sender, EventArgs e)

        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_in_Load_1(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex.IsMatch(textBox6   .Text, "[ ^ 0-9]");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }





        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool checkAccount(string ACC)
        {
            return Regex.IsMatch(ACC, "^[a-zA-Z0-9]{6,30}$");
        }
        public bool checkGmail(string Gm)
        {
            return Regex.IsMatch(Gm, @"^[a-zA-Z0-9_.]{4,20}@gmail.com(.vn|)$");
        }
        public const string MatchEmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
        + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
        + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
        + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else
                return
                    false;
        }
        //private void label10_Click(object sender, EventArgs e)
        //{
        //    Modify modify = new Modify();
        //    if (textBox1.Texts.Trim() == "")
        //    {
        //        MessageBox.Show("Bạn chưa nhập họ tên.");
        //        textBox1.Focus();
        //    }

        //    else if (!checkGmail(textBox6.Texts))
        //    {
        //        MessageBox.Show("Bạn Nhập sai định dạng Gmail.");
        //        textBox6.Focus();
        //    }
        //    else if (textBox2.Texts.Trim() == "")

        //    {
        //        MessageBox.Show("Bạn chưa số điên thoại.");
        //        textBox2.Focus();
        //    }

        //    else if (!checkAccount(textBox3.Texts))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên tài khoản với độ dài từ 6-30 kí tự,với các ký tự chữ và số.");
        //        textBox3.Focus();
        //    }
        //    else if (!checkAccount(textBox4.Texts))
        //    {
        //        MessageBox.Show("Vui lòng nhập mặt khẩu với độ dài từ 6-30 kí tự,với các ký tự chữ và số.");
        //        textBox4.Focus();
        //    }
        //    else if (textBox4.Texts.Trim() != textBox5.Texts.Trim())
        //    {
        //        MessageBox.Show("Xác nhận mặt khẩu không khớp.");
        //        textBox5.Focus();
        //    }
        //    else if (modify.TK("SELECT *FROM SIGNIN WHERE GMAIL ='" + textBox6.Texts + "'").Count != 0)
        //    {
        //        MessageBox.Show("Gmail này đã được đăng ký, vui lòng nhập gmail khác.");
        //    }
        //    else if (modify.TK("SELECT *FROM SIGNIN WHERE TK ='" + textBox3.Texts + "'").Count != 0)
        //    {
        //        MessageBox.Show("Tài khoản này đã được đăng ký, vui lòng tạo tài khoản khác.");
        //    }
        //    else
        //        try
        //        {
        //            string query = "INSERT INTO SIGNIN(HOTEN,GIOITINH,NGAYSINH,SDT,GMAIL,TK,MK) VALUES(N'" + textBox1.Texts + "','" + comboBox1.Texts + "','" + dateTimePicker1.Value.ToString() + "','" + textBox2.Texts + "','" + textBox6.Texts + "','" + textBox3.Texts + "','" + textBox4.Texts + "')";
        //            modify.CMD(query);
        //            if (MessageBox.Show("Chúc mừng bạn đã tạo tài khoản thành công,bạn muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //            {
        //                this.Hide();
        //                login log = new login();
        //                log.ShowDialog();
        //            }

        //            textBox6.Texts = textBox1.Texts = comboBox1.Texts = textBox2.Texts = textBox3.Texts = textBox4.Texts = textBox5.Texts = "";

        //        }
        //        catch
        //        {
        //            MessageBox.Show("Tài khoản và mặt khẩu không được viết có dấu.");
        //        }




        //}

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2__TextChanged(object sender, EventArgs e)
        {
              

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      /*  public static string Base64Encode(string plainText)
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
        //public static string MD5Hash(string input)
        //{
        //    StringBuilder hash = new StringBuilder();
        //    MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
        //    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

        //    for (int i = 0; i < bytes.Length; i++)
        //    {
        //        hash.Append(bytes[i].ToString("x2"));
        //    }
        //    return hash.ToString();
        //}
        private void label10_Click_1(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            if (textBox1.Texts.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên.");
                textBox1.Focus();
            }

            else if (IsEmail(textBox6.Texts)==false)
            {
                MessageBox.Show("Bạn Nhập sai định dạng Gmail.");
                textBox6.Focus();
            }
            else if (textBox2.Texts.Trim() == "")

            {
                MessageBox.Show("Bạn chưa số điên thoại.");
                textBox2.Focus();
            }

            else if (!checkAccount(textBox3.Texts))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản với độ dài từ 6-30 kí tự,với các ký tự chữ và số.");
                textBox3.Focus();
            }
            else if (!checkAccount(textBox4.Texts))
            {
                MessageBox.Show("Vui lòng nhập mặt khẩu với độ dài từ 6-30 kí tự,với các ký tự chữ và số.");
                textBox4.Focus();
            }
            else if (textBox4.Texts.Trim() != textBox5.Texts.Trim())
            {
                MessageBox.Show("Xác nhận mặt khẩu không khớp.");
                textBox5.Focus();
            }
            else if (modify.TK("SELECT *FROM SIGNIN WHERE GMAIL ='" + textBox6.Texts + "'").Count != 0)
            {
                MessageBox.Show("Gmail này đã được đăng ký, vui lòng nhập gmail khác.");
            }
            else if (modify.TK("SELECT *FROM SIGNIN WHERE TK ='" + textBox3.Texts + "'").Count != 0)
            {
                MessageBox.Show("Tài khoản này đã được đăng ký, vui lòng tạo tài khoản khác.");
            }
            else
                try
                {
                    string passEncode = Encrypt(textBox4.Texts);
                    string query = "INSERT INTO SIGNIN(HOTEN,GIOITINH,NGAYSINH,SDT,GMAIL,TK,MK) VALUES(N'" + textBox1.Texts + "', N'" + comboBox1.Texts + "','" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "','" + textBox2.Texts + "','" + textBox6.Texts + "','" + textBox3.Texts + "','" + passEncode + "')";
                    modify.CMD(query);
                    if (MessageBox.Show("Chúc mừng bạn đã tạo tài khoản thành công,bạn muốn đăng nhập ngay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Login log = new Login();
                        log.StartPosition = FormStartPosition.CenterScreen;
                        log.Show();
                    }

                    textBox6.Texts = textBox1.Texts = comboBox1.Texts = textBox2.Texts = textBox3.Texts = textBox4.Texts = textBox5.Texts = "";

                }
                catch
                {
                    MessageBox.Show("Tài khoản và mặt khẩu không đúng định dạng vui lòng kiểm tra lại.");
                    

                }
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
     



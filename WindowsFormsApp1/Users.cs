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
    public partial class Users : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader data;
        public User item = new User();

        public Users()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @" Data Source = MSI; Initial Catalog = CINEMA_LETTER; Integrated Security = True";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      /*  string hash = "hello";
        public string Decode(string code)
        {
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
        }*/
        private void GetData()
        {

            //byte[] data = Convert.FromBase64String(txtEncrypt.Text);
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
            //    //Decrypt data by hash key
            //    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            //    {
            //        ICryptoTransform transform = tripDes.CreateDecryptor();
            //        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            //        txtDecrypt.Text = UTF8Encoding.UTF8.GetString(results);
            //    }
            //}
            flowLayoutPanel1.Controls.Clear();   
            con.Open();
            cmd = new SqlCommand("SELECT * FROM SIGNIN", con);
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                 item = new User();
                item.Hoten = data["HOTEN"].ToString();
                item.Tk = data["TK"].ToString();
                item.Mk = data["MK"].ToString();
                item.Id = data["ID"].ToString();
                item.Sdt = data["SDT"].ToString();
                item.Gm = data["GMAIL"].ToString();
                item.Ns = data["NGAYSINH"].ToString();
                item.Gt = data["GIOITINH"].ToString();
                flowLayoutPanel1.Controls.Add(item);

            }
            data.Close();
            con.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class User : UserControl
    {
       
        public User()
        {
            InitializeComponent();

        }

        private void User_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        string hash = "hello";
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
        }

        public string ID;
        public string Id{
            get { return ID; }
            set { ID = value; idd.Text = value; }
             }
        public string HOTEN;
        public string Hoten
        {
            get { return HOTEN; }
            set { HOTEN = value; htt.Text = value; }
        }
        public string TK;
        public string Tk {
            get { return TK; }
            set { TK = value; tkkk.Text = value; }
        }

        public string SDT;
        public string Sdt {
            get { return SDT; }
            set { SDT = value; sdttt.Text = value; }
        }
        public string GT;
        public string Gt {
            get { return GT; }
            set { GT = value; gttt.Text = value; }
        }
        public string NS;
        public string Ns {
            get { return NS; }
            set { NS = value; nsss.Text =   value; }
        }
        public string GM;
        public string Gm {
            get { return GM; }
            set { GM = value; gmmm.Text = value; }

        }
        public string MK;     
        //private  void  Decodee(string decode)
        //{
        //    string hash = "x2";
        //    byte[] data = Convert.FromBase64String(MK);
        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
        //        //Decrypt data by hash key
        //        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
        //        {
        //            ICryptoTransform transform = tripDes.CreateDecryptor();
        //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
        //            MK = UTF8Encoding.UTF8.GetString(results);
        //        }
        //    }
        //}
        public string Mk
        {
            get { return MK; }
            set { MK =  value; mkkk.Text = value; }
        }
        SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            try
            {
                string sql = "DELETE FROM SIGNIN  WHERE ID= '" + idd.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader dbr;
                Con.Open();
                dbr = cmd.ExecuteReader();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void label8_Click(object sender, EventArgs e)
        {
        //    SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
        //    string sql = "UPDATE SIGNIN SET TK='" + tkkk.Text + "',MK='" + mkkk.Text + "',HOTEN= N'" + htt.Text + "',GIOITINH= N'" + gttt.Text + "',NGAYSINH='" + nsss.Text + "',SDT='" + sdttt.Text + "',GMAIL='" + gmmm.Text + "' WHERE ID= '" + idd.Text + "'";
        //    SqlCommand cmd = new SqlCommand(sql, Con);
        //    SqlDataReader dbr;
        //    Con.Open();
        //    dbr = cmd.ExecuteReader();
        //    MessageBox.Show(" Thay đổi thông tin thành công.");
        SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");
           string sql = "UPDATE SIGNIN SET TK='" + tkkk.Text + "',MK='" + Encrypt(mkkk.Text) + "',HOTEN= N'" + htt.Text + "',GIOITINH= N'" + gttt.Text + "',NGAYSINH='" + nsss.Text + "',SDT='" + sdttt.Text + "',GMAIL='" + gmmm.Text + "' WHERE ID= '" +idd.Text+ "'";
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
          catch( Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void sdttt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@" Data Source=MSI;Initial Catalog=CINEMA_LETTER;Integrated Security=True");

            try
            {
                string sql = "DELETE FROM SIGIN  WHERE ID= '" + idd.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader dbr;
                Con.Open();
                dbr = cmd.ExecuteReader();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

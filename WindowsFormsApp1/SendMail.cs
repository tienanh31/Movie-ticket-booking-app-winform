using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class SendMail : Form
    {


        public SendMail()
        {
            InitializeComponent();
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
        private void SendMail_Load(object sender, EventArgs e)
        {
            textBox1.Text = Mail.Luu.Ten;
            textBox2.Text = Mail.Luu.Gmail;
            textBox3.Text = Mail.Luu.Sdt;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //SmtpClient client = new SmtpClient();
            //client.Port = 587;
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Credentials = new NetworkCredential("caophamtienanh@gmail.com", "01266948845");
            //MailMessage mailMessage = new MailMessage();
            //mailMessage.From = new MailAddress("caophamtienanh@gmail.com");
            //mailMessage.To.Add(textBox2.Text.Trim());
            //mailMessage.Subject = textBox4.Text.Trim();
            //mailMessage.IsBodyHtml = true;
            //mailMessage.Body = richTextBox1.Text.Trim();
            //client.Send(mailMessage);
            Send(textBox2.Text.Trim(), textBox4.Text.Trim(), richTextBox1.Text.Trim());
        }
        public void Send(string sendMoKanino, string subjectMo, string messageMoBes)
        {
            if (IsEmail(textBox2.Text) == false) MessageBox.Show("Sai định dạng Gmail, không thể gửi");
            else
            {
                try
                {

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("caophamtienanh@gmail.com");
                    mail.To.Add(sendMoKanino);
                    mail.Subject = subjectMo;
                    mail.Body = messageMoBes;

                    SmtpClient smptClient = new SmtpClient();
                    smptClient.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential credential = new NetworkCredential();
                    credential.UserName = "caophamtienanh@gmail.com";
                    credential.Password = "01266948845";
                    smptClient.Credentials = credential;
                    smptClient.Port = 587;
                    smptClient.EnableSsl = true;
                    smptClient.Send(mail);
                    MessageBox.Show("Phản hồi thư thành công.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Họ Tên")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Họ Tên";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Gmail")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Gmail";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Số điện thoại")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Số điện thoại";
                

                
            }

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Tiêu đề")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Tiêu đề";
            }

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Nội dung")
            {
                richTextBox1.Text = "";
            }

        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Nội dung";


            }

        }
    }
}

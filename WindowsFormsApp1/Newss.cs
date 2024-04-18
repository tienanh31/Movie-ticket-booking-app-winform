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
    public partial class Newss : UserControl
    {
        public Newss()
        {
            InitializeComponent();
        }
        private string Tieude;
        private string Noidung;
        private Image Pic;

        public Image PIC
        {
            get { return Pic; }
            set { Pic = value; pictureBox1.Image = value; }
        }

        public string TIEUDE
        {
            get { return Tieude; }
            set { Tieude = value; label6.Text = value; }
        }

             public string NOIDUNG  
        {
            get { return Noidung; }
            set { Noidung = value; richTextBox1.Text = value; }
        }
        private void Newss_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Movie_Item : UserControl
    {
        public Movie_Item()
        {
            InitializeComponent();
        }
        private string TenPhim;

        public string  TENPHIM {
            get { return TenPhim; }
            set { TenPhim = value; bunifuButton1.Text = value; }
        }
        private Image Poster;

        public Image  poster {
            get { return Poster; }
            set { Poster = value; pictureBox1.Image = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Movie_Item_Load(object sender, EventArgs e)
        {

        }

        private void Movie_Item_Click(object sender, EventArgs e)
        {

        }
    }
}

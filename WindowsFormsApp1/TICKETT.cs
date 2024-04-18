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
    public partial class TICKETT : UserControl
    {
        public TICKETT()
        {
            InitializeComponent();
        }
        public Image Pic;
        public Image PIC {
            get { return Pic; }
            set { Pic = value; pictureBox1.Image = value; }
        }
        public string IdVe;
        public string IDVE {
            get { return IdVe; }
            set { IdVe = value; id.Text = value; }
        }
        public string Nguoidat;
        public string NGUOIDAT {
            get { return Nguoidat; }
            set { Nguoidat = value; nd.Text = value; }
        }
        public string Thoigian;
        public string THOIGIAN {
            get { return Thoigian; }
            set { Thoigian = value; tg.Text = value; }
        }
        public string Phong;
        public string PHONG {
            get { return Phong; }
            set { Phong = value; phog.Text = value; }
        }
        public string Ghe;
        public string GHE {
            get { return Ghe; }
            set { Ghe = value; ghee.Text = value; }
        }
        public string Tongtien;
        public string TONGTIEN {
            get { return Tongtien; }
            set { Tongtien = value; tt.Text = value; }
        }
        public string Phim;
        public string PHIM {
            get { return Phim; }
            set { Phim = value; phimm.Text = value; }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void TICKETT_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {

            Print p = new Print();
            p.print(pictureBox1.Image,id.Text, nd.Text, phimm.Text, tg.Text, phog.Text, ghee.Text, tt.Text);
        }
    }
}


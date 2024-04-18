using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            bunifuButton1.IdleBorderRadius = 20;
            bunifuButton2.IdleBorderRadius = 20;
            bunifuButton3.IdleBorderRadius = 20;
            bunifuButton4.IdleBorderRadius = 20;
            bunifuButton5.IdleBorderRadius = 20;
            bunifuButton6.IdleBorderRadius = 20;
            bunifuButton7.IdleBorderRadius = 20;
            bunifuButton8.IdleBorderRadius = 20;

        }
        bool expand = false;


        


        public void LoadFormCustomer(object Form)
        {   if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 250;
            f.Top = 100;
            f.BringToFront();
            f.Show();
            panel1.Controls.Add(f);
            f.Show();
        }
        public void LoadFormMovie(object Form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.BackgroundImage = panel1.BackgroundImage;
        
            f.BringToFront();
            panel1.Controls.Add(f);
            f.Show();
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
        }


        private bool isCollapsed;


        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (flowLayoutPanel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!expand)
                {
                    expand = true;
                    flowLayoutPanel1.Width = 225;
                }
            }
            else
            {
                if (expand)
                {
                    expand = false;
                    flowLayoutPanel1.Visible = false;
                    flowLayoutPanel1.Width = 50;
                    bunifuTransition1.Show(flowLayoutPanel1);
                }
            }
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            LoadFormMovie(new MoreMovie());
    
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            LoadFormCustomer(new Customers());


        }



        private void bunifuButton4_Click_2(object sender, EventArgs e)
        {
                timer2.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            LoadFormMovie(new Info2DD());
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new Info4DXX());

        }

        private void bunifuButton8_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {

            LoadFormMovie(new Info2DD());

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            bunifuButton5.Text = Login.LuuThongTin.ten;
            if(Login.LuuThongTin.ten=="admin"|| Login.LuuThongTin.ten == "ADMIN")
            {
            bunifuButton13.Visible=  bunifuButton12.Visible=  bunifuButton10.Visible = bunifuButton11.Visible = bunifuButton9.Visible = true;
            }    
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new MoreMovie());
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            LoadFormCustomer(new Customers());
        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void bunifuButton6_Click_2(object sender, EventArgs e)
        {
            LoadFormMovie(new Info2DD());

        }

        private void bunifuButton7_Click_1(object sender, EventArgs e)
        {
            LoadFormMovie(new Info4DXX());

        }

        private void bunifuButton8_Click_2(object sender, EventArgs e)
        {
            LoadFormMovie(new InfoCouple());

        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new Movie_Show());

        }

        private void bunifuButton11_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new Showw());

        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new Users());

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton3_Click_2(object sender, EventArgs e)
        {
            LoadFormMovie(new Ticked());

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton12_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new Gmail());

        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            LoadFormMovie(new News());


        }
    }
}

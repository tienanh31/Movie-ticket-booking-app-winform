using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SeatButton : System.Windows.Forms.Button
    {
        public SeatButton() : base()
        {
            this.Click += new EventHandler(this.button_Click_Custom);
        }
        public void button_Click_Custom(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Orange)
                this.BackColor = Color.Blue;
            else if (this.BackColor == Color.Plum)
                this.BackColor = Color.Blue;    
            else if (this.BackColor == Color.Brown)
                this.BackColor = Color.Blue;
            else if(this.BackColor==Color.Blue|| this.BackColor == Color.White)
            MessageBox.Show("Vị trí này đã có người đặt.");
        }
    }
}

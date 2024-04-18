using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace WindowsFormsApp1
{
    class Print
    {
        public Image Img;
        public String id;
        String booker,datetime,seat,room,film,tongtien;
        public void print( Image Img, String id, String booker,string phim, string datetime, String room, String seat,string tongtien)
        {
            this.Img = Img;
            this.id = id;
            this.datetime = datetime;          
            this.booker = booker;
            this.room = room;
            this.seat = seat;
            this.film = phim;
            this.tongtien = tongtien;
            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
            pd.Document = pdoc;
            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);
            pd.ShowDialog();
            pdoc.Print();

        }
       
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {

        

            Graphics graphics = e.Graphics;         
            Pen blackPen = new Pen(Color.Black, 1);
            graphics.DrawRectangle(blackPen, 10, 110, 250, 300);
            try
            {
                graphics.DrawImage(Img, 15, 115, 240, 290);

            }
            catch
            {
                graphics.DrawString("", new Font("UVN Bai Sau", 50, FontStyle.Bold), new SolidBrush(Color.Black), 250, 95);
            }
            graphics.DrawRectangle(blackPen, 261, 110, 470 + 110, 300);
            graphics.DrawString(" LeTter CinemA ", new Font("UVN Bai Sau", 50, FontStyle.Bold), new SolidBrush(Color.Black), 200, 20);
            graphics.DrawString("ID vé : " + id, new Font("UVN Bai Sau", 16, FontStyle.Bold), new SolidBrush(Color.Black), 300, 110);
            graphics.DrawString("Người đặt : " + booker, new Font("UVN Bai Sau", 14), new SolidBrush(Color.Black), 300, 140);
            graphics.DrawString("Phim : " + film + "/-  ", new Font("UVN Bai Sau", 14), new SolidBrush(Color.Black), 300, 170);
            graphics.DrawString("Thời gian : "+datetime , new Font("UVN Bai Sau", 14), new SolidBrush(Color.Black), 300, 200);
            graphics.DrawString("Phòng : " + room, new Font("UVN Bai Sau", 14), new SolidBrush(Color.Black), 300, 230);
            graphics.DrawString("Ghế : " + seat, new Font("UVN Bai Sau", 14), new SolidBrush(Color.Red), 300, 260);
            graphics.DrawString("Tổng tiền : " + tongtien+"đ", new Font("UVN Bai Sau", 14), new SolidBrush(Color.Red), 300, 290);
            graphics.DrawString("*AAAAAAAFFFFFFAAA*", new Font("3 of 9 Barcode",20), new SolidBrush(Color.Black), 380,330);
            graphics.DrawString("*AAAAAAAFFFFFFAAA*", new Font("3 of 9 Barcode", 20), new SolidBrush(Color.Black), 380, 340);

        }


    }
}

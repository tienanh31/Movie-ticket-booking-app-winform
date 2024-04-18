
namespace WindowsFormsApp1
{
    partial class Ticked
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tickett1 = new WindowsFormsApp1.TICKETT();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tickett1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(910, 475);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tickett1
            // 
            this.tickett1.GHE = null;
            this.tickett1.IDVE = null;
            this.tickett1.Location = new System.Drawing.Point(3, 3);
            this.tickett1.Name = "tickett1";
            this.tickett1.NGUOIDAT = null;
            this.tickett1.PHIM = null;
            this.tickett1.PHONG = null;
            this.tickett1.PIC = null;
            this.tickett1.Size = new System.Drawing.Size(875, 450);
            this.tickett1.TabIndex = 0;
            this.tickett1.THOIGIAN = null;
            this.tickett1.TONGTIEN = null;
            this.tickett1.Load += new System.EventHandler(this.tickett1_Load_3);
            // 
            // Ticked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticked";
            this.Text = "Ticked";
            this.Load += new System.EventHandler(this.Ticked_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TICKETT tickett1;
    }
}
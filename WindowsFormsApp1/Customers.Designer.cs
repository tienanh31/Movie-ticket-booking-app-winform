
namespace WindowsFormsApp1
{
    partial class Customers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new CustomControls.RJControls.RJTextBox();
            this.comboBox1 = new CustomControls.RJControls.RJTextBox();
            this.textBox4 = new CustomControls.RJControls.RJTextBox();
            this.textBox5 = new CustomControls.RJControls.RJTextBox();
            this.textBox2 = new CustomControls.RJControls.RJTextBox();
            this.button8 = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("UVN Bai Sau", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 44);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Bai Sau", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(84, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ và Tên :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Bai Sau", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(97, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "Giới Tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Bai Sau", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(78, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày Sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Bai Sau", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 38);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số Điện thoại :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UVN Bai Sau", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(74, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 38);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tài khoản :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UVN Bai Sau", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(75, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 38);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mặt Khẩu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UVN Bai Sau", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(123, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 38);
            this.label8.TabIndex = 25;
            this.label8.Text = "Gmail :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox1.BorderRadius = 10;
            this.textBox1.BorderSize = 3;
            this.textBox1.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(247, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox1.PasswordChar = false;
            this.textBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox1.PlaceholderText = "";
            this.textBox1.Size = new System.Drawing.Size(292, 48);
            this.textBox1.TabIndex = 27;
            this.textBox1.Texts = "";
            this.textBox1.UnderlinedStyle = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.comboBox1.BorderRadius = 10;
            this.comboBox1.BorderSize = 3;
            this.comboBox1.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.Location = new System.Drawing.Point(246, 70);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Multiline = false;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.comboBox1.PasswordChar = false;
            this.comboBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.comboBox1.PlaceholderText = "";
            this.comboBox1.Size = new System.Drawing.Size(292, 48);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Texts = "";
            this.comboBox1.UnderlinedStyle = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox4.BorderRadius = 10;
            this.textBox4.BorderSize = 3;
            this.textBox4.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(246, 190);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = false;
            this.textBox4.Name = "textBox4";
            this.textBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox4.PasswordChar = false;
            this.textBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox4.PlaceholderText = "";
            this.textBox4.Size = new System.Drawing.Size(292, 48);
            this.textBox4.TabIndex = 29;
            this.textBox4.Texts = "";
            this.textBox4.UnderlinedStyle = false;
            this.textBox4._TextChanged += new System.EventHandler(this.textBox4__TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox5.BorderRadius = 10;
            this.textBox5.BorderSize = 3;
            this.textBox5.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.Location = new System.Drawing.Point(245, 254);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = false;
            this.textBox5.Name = "textBox5";
            this.textBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox5.PasswordChar = false;
            this.textBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox5.PlaceholderText = "";
            this.textBox5.Size = new System.Drawing.Size(292, 48);
            this.textBox5.TabIndex = 30;
            this.textBox5.Texts = "";
            this.textBox5.UnderlinedStyle = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox2.BorderRadius = 10;
            this.textBox2.BorderSize = 3;
            this.textBox2.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(245, 378);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox2.PasswordChar = false;
            this.textBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox2.PlaceholderText = "";
            this.textBox2.Size = new System.Drawing.Size(292, 48);
            this.textBox2.TabIndex = 32;
            this.textBox2.Texts = "";
            this.textBox2.UnderlinedStyle = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button8.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.button8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button8.BorderRadius = 10;
            this.button8.BorderSize = 3;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("UVN Bai Sau", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(242, 443);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(292, 40);
            this.button8.TabIndex = 33;
            this.button8.Text = "Cập nhật thông tin";
            this.button8.TextColor = System.Drawing.Color.White;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(854, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // textBox6
            // 
            this.textBox6.AcceptsReturn = false;
            this.textBox6.AcceptsTab = false;
            this.textBox6.AnimationSpeed = 200;
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox6.BackColor = System.Drawing.Color.Transparent;
            this.textBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox6.BackgroundImage")));
            this.textBox6.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBox6.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox6.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBox6.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox6.BorderRadius = 10;
            this.textBox6.BorderThickness = 3;
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.DefaultFont = new System.Drawing.Font("UVN Bai Sau", 13.8F);
            this.textBox6.DefaultText = "";
            this.textBox6.FillColor = System.Drawing.Color.White;
            this.textBox6.HideSelection = true;
            this.textBox6.IconLeft = null;
            this.textBox6.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.IconPadding = 10;
            this.textBox6.IconRight = null;
            this.textBox6.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Lines = new string[0];
            this.textBox6.Location = new System.Drawing.Point(245, 314);
            this.textBox6.MaxLength = 32767;
            this.textBox6.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBox6.Modified = false;
            this.textBox6.Multiline = false;
            this.textBox6.Name = "textBox6";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox6.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBox6.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox6.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBox6.OnIdleState = stateProperties4;
            this.textBox6.Padding = new System.Windows.Forms.Padding(3);
            this.textBox6.PasswordChar = '\0';
            this.textBox6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBox6.PlaceholderText = "Enter text";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox6.SelectedText = "";
            this.textBox6.SelectionLength = 0;
            this.textBox6.SelectionStart = 0;
            this.textBox6.ShortcutsEnabled = true;
            this.textBox6.Size = new System.Drawing.Size(294, 51);
            this.textBox6.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBox6.TabIndex = 36;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox6.TextMarginBottom = 0;
            this.textBox6.TextMarginLeft = 3;
            this.textBox6.TextMarginTop = 0;
            this.textBox6.TextPlaceholder = "Enter text";
            this.textBox6.UseSystemPasswordChar = false;
            this.textBox6.WordWrap = true;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControls.RJControls.RJTextBox textBox1;
        private CustomControls.RJControls.RJTextBox comboBox1;
        private CustomControls.RJControls.RJTextBox textBox4;
        private CustomControls.RJControls.RJTextBox textBox5;
        private CustomControls.RJControls.RJTextBox textBox2;
        private CustomControls.RJControls.RJButton button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.UI.WinForms.BunifuTextBox textBox6;
    }
}
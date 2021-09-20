
namespace datphong
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_songayo = new System.Windows.Forms.NumericUpDown();
            this.rb_day = new System.Windows.Forms.RadioButton();
            this.rb_trong = new System.Windows.Forms.RadioButton();
            this.cbox_loaiphong = new System.Windows.Forms.ComboBox();
            this.txt_giaphong = new System.Windows.Forms.TextBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.btn_huyphong = new System.Windows.Forms.Button();
            this.btn_datphong = new System.Windows.Forms.Button();
            this.btn_themphong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_songayo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "motel.jpg");
            this.imageList1.Images.SetKeyName(1, "notepad_txt_file.ico");
            this.imageList1.Images.SetKeyName(2, "Room.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.nud_songayo);
            this.groupBox1.Controls.Add(this.rb_day);
            this.groupBox1.Controls.Add(this.rb_trong);
            this.groupBox1.Controls.Add(this.cbox_loaiphong);
            this.groupBox1.Controls.Add(this.txt_giaphong);
            this.groupBox1.Controls.Add(this.txt_maphong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nud_songayo
            // 
            this.nud_songayo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_songayo.Location = new System.Drawing.Point(252, 229);
            this.nud_songayo.Name = "nud_songayo";
            this.nud_songayo.Size = new System.Drawing.Size(125, 30);
            this.nud_songayo.TabIndex = 10;
            // 
            // rb_day
            // 
            this.rb_day.AutoSize = true;
            this.rb_day.Location = new System.Drawing.Point(251, 191);
            this.rb_day.Name = "rb_day";
            this.rb_day.Size = new System.Drawing.Size(67, 27);
            this.rb_day.TabIndex = 9;
            this.rb_day.Text = "Đầy";
            this.rb_day.UseVisualStyleBackColor = true;
            // 
            // rb_trong
            // 
            this.rb_trong.AutoSize = true;
            this.rb_trong.Checked = true;
            this.rb_trong.Location = new System.Drawing.Point(251, 158);
            this.rb_trong.Name = "rb_trong";
            this.rb_trong.Size = new System.Drawing.Size(91, 27);
            this.rb_trong.TabIndex = 8;
            this.rb_trong.TabStop = true;
            this.rb_trong.Text = "Trống";
            this.rb_trong.UseVisualStyleBackColor = true;
            // 
            // cbox_loaiphong
            // 
            this.cbox_loaiphong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_loaiphong.FormattingEnabled = true;
            this.cbox_loaiphong.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbox_loaiphong.Location = new System.Drawing.Point(252, 70);
            this.cbox_loaiphong.Name = "cbox_loaiphong";
            this.cbox_loaiphong.Size = new System.Drawing.Size(125, 30);
            this.cbox_loaiphong.TabIndex = 7;
            this.cbox_loaiphong.Text = "A";
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaphong.Location = new System.Drawing.Point(252, 113);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.ReadOnly = true;
            this.txt_giaphong.Size = new System.Drawing.Size(125, 30);
            this.txt_giaphong.TabIndex = 6;
            this.txt_giaphong.Text = "150000";
            // 
            // txt_maphong
            // 
            this.txt_maphong.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphong.Location = new System.Drawing.Point(252, 32);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.ReadOnly = true;
            this.txt_maphong.Size = new System.Drawing.Size(125, 30);
            this.txt_maphong.TabIndex = 5;
            this.txt_maphong.Text = "A1";
            this.txt_maphong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số ngày ở :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại phòng :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(19, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá phòng :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(19, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng phòng :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_thanhtoan);
            this.groupBox2.Controls.Add(this.btn_huyphong);
            this.groupBox2.Controls.Add(this.btn_datphong);
            this.groupBox2.Controls.Add(this.btn_themphong);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(6, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.Sienna;
            this.btn_thanhtoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_thanhtoan.Location = new System.Drawing.Point(238, 184);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(139, 47);
            this.btn_thanhtoan.TabIndex = 14;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            // 
            // btn_huyphong
            // 
            this.btn_huyphong.BackColor = System.Drawing.Color.Sienna;
            this.btn_huyphong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_huyphong.Location = new System.Drawing.Point(238, 131);
            this.btn_huyphong.Name = "btn_huyphong";
            this.btn_huyphong.Size = new System.Drawing.Size(139, 47);
            this.btn_huyphong.TabIndex = 13;
            this.btn_huyphong.Text = "Hủy phòng";
            this.btn_huyphong.UseVisualStyleBackColor = false;
            // 
            // btn_datphong
            // 
            this.btn_datphong.BackColor = System.Drawing.Color.Sienna;
            this.btn_datphong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_datphong.Location = new System.Drawing.Point(238, 78);
            this.btn_datphong.Name = "btn_datphong";
            this.btn_datphong.Size = new System.Drawing.Size(139, 47);
            this.btn_datphong.TabIndex = 12;
            this.btn_datphong.Text = "Đặt phòng";
            this.btn_datphong.UseVisualStyleBackColor = false;
            // 
            // btn_themphong
            // 
            this.btn_themphong.BackColor = System.Drawing.Color.Sienna;
            this.btn_themphong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_themphong.Location = new System.Drawing.Point(238, 25);
            this.btn_themphong.Name = "btn_themphong";
            this.btn_themphong.Size = new System.Drawing.Size(140, 47);
            this.btn_themphong.TabIndex = 11;
            this.btn_themphong.Text = "Thêm phòng";
            this.btn_themphong.UseVisualStyleBackColor = false;
            this.btn_themphong.Click += new System.EventHandler(this.btn_themphong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 204);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(395, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(752, 503);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1152, 524);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_songayo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_giaphong;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.RadioButton rb_trong;
        private System.Windows.Forms.ComboBox cbox_loaiphong;
        private System.Windows.Forms.RadioButton rb_day;
        private System.Windows.Forms.NumericUpDown nud_songayo;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button btn_huyphong;
        private System.Windows.Forms.Button btn_datphong;
        private System.Windows.Forms.Button btn_themphong;
    }
}


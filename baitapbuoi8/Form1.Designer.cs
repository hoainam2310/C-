
namespace baitapbuoi8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.gb_Image = new System.Windows.Forms.GroupBox();
            this.txb_Point_Y = new System.Windows.Forms.TextBox();
            this.txb_Point_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Load_Image = new System.Windows.Forms.Button();
            this.gb_Draw = new System.Windows.Forms.GroupBox();
            this.nud_PenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.rd_Rectangle = new System.Windows.Forms.RadioButton();
            this.rd_Fill_Rectangle = new System.Windows.Forms.RadioButton();
            this.rd_String = new System.Windows.Forms.RadioButton();
            this.rd_Ellipse = new System.Windows.Forms.RadioButton();
            this.rd_Fill_Ellipse = new System.Windows.Forms.RadioButton();
            this.rdb_Line = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.gb_Image.SuspendLayout();
            this.gb_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btn_Clean);
            this.groupBox1.Controls.Add(this.gb_Image);
            this.groupBox1.Controls.Add(this.gb_Draw);
            this.groupBox1.Location = new System.Drawing.Point(660, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(352, 593);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Clean
            // 
            this.btn_Clean.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clean.ForeColor = System.Drawing.Color.White;
            this.btn_Clean.Location = new System.Drawing.Point(22, 348);
            this.btn_Clean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(326, 53);
            this.btn_Clean.TabIndex = 8;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.UseVisualStyleBackColor = false;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // gb_Image
            // 
            this.gb_Image.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_Image.Controls.Add(this.txb_Point_Y);
            this.gb_Image.Controls.Add(this.txb_Point_X);
            this.gb_Image.Controls.Add(this.label2);
            this.gb_Image.Controls.Add(this.btn_Load_Image);
            this.gb_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Image.Location = new System.Drawing.Point(22, 427);
            this.gb_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Image.Name = "gb_Image";
            this.gb_Image.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Image.Size = new System.Drawing.Size(326, 162);
            this.gb_Image.TabIndex = 2;
            this.gb_Image.TabStop = false;
            this.gb_Image.Text = "Image";
            // 
            // txb_Point_Y
            // 
            this.txb_Point_Y.Location = new System.Drawing.Point(237, 54);
            this.txb_Point_Y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Point_Y.Name = "txb_Point_Y";
            this.txb_Point_Y.Size = new System.Drawing.Size(76, 26);
            this.txb_Point_Y.TabIndex = 12;
            this.txb_Point_Y.Text = "100";
            this.txb_Point_Y.TextChanged += new System.EventHandler(this.txb_Point_Y_TextChanged);
            // 
            // txb_Point_X
            // 
            this.txb_Point_X.Location = new System.Drawing.Point(130, 54);
            this.txb_Point_X.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_Point_X.Name = "txb_Point_X";
            this.txb_Point_X.Size = new System.Drawing.Size(76, 26);
            this.txb_Point_X.TabIndex = 11;
            this.txb_Point_X.Text = "100";
            this.txb_Point_X.TextChanged += new System.EventHandler(this.txb_Point_X_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Point X, Y";
            // 
            // btn_Load_Image
            // 
            this.btn_Load_Image.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Load_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Load_Image.Location = new System.Drawing.Point(12, 103);
            this.btn_Load_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Load_Image.Name = "btn_Load_Image";
            this.btn_Load_Image.Size = new System.Drawing.Size(300, 46);
            this.btn_Load_Image.TabIndex = 9;
            this.btn_Load_Image.Text = "Load Image";
            this.btn_Load_Image.UseVisualStyleBackColor = false;
            this.btn_Load_Image.Click += new System.EventHandler(this.btn_Load_Image_Click);
            // 
            // gb_Draw
            // 
            this.gb_Draw.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_Draw.Controls.Add(this.nud_PenWidth);
            this.gb_Draw.Controls.Add(this.label1);
            this.gb_Draw.Controls.Add(this.btn_PenColor);
            this.gb_Draw.Controls.Add(this.rd_Rectangle);
            this.gb_Draw.Controls.Add(this.rd_Fill_Rectangle);
            this.gb_Draw.Controls.Add(this.rd_String);
            this.gb_Draw.Controls.Add(this.rd_Ellipse);
            this.gb_Draw.Controls.Add(this.rd_Fill_Ellipse);
            this.gb_Draw.Controls.Add(this.rdb_Line);
            this.gb_Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Draw.ForeColor = System.Drawing.Color.Black;
            this.gb_Draw.Location = new System.Drawing.Point(22, 17);
            this.gb_Draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Draw.Name = "gb_Draw";
            this.gb_Draw.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Draw.Size = new System.Drawing.Size(326, 317);
            this.gb_Draw.TabIndex = 1;
            this.gb_Draw.TabStop = false;
            this.gb_Draw.Text = "Draw";
            // 
            // nud_PenWidth
            // 
            this.nud_PenWidth.Location = new System.Drawing.Point(113, 261);
            this.nud_PenWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_PenWidth.Name = "nud_PenWidth";
            this.nud_PenWidth.Size = new System.Drawing.Size(188, 26);
            this.nud_PenWidth.TabIndex = 8;
            this.nud_PenWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pen Width";
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.ForeColor = System.Drawing.Color.White;
            this.btn_PenColor.Location = new System.Drawing.Point(27, 178);
            this.btn_PenColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(274, 53);
            this.btn_PenColor.TabIndex = 6;
            this.btn_PenColor.Text = "Pen Color";
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.btn_PenColor_Click);
            // 
            // rd_Rectangle
            // 
            this.rd_Rectangle.AutoSize = true;
            this.rd_Rectangle.Location = new System.Drawing.Point(27, 89);
            this.rd_Rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_Rectangle.Name = "rd_Rectangle";
            this.rd_Rectangle.Size = new System.Drawing.Size(100, 24);
            this.rd_Rectangle.TabIndex = 5;
            this.rd_Rectangle.TabStop = true;
            this.rd_Rectangle.Text = "Rectangle";
            this.rd_Rectangle.UseVisualStyleBackColor = true;
            // 
            // rd_Fill_Rectangle
            // 
            this.rd_Fill_Rectangle.AutoSize = true;
            this.rd_Fill_Rectangle.Location = new System.Drawing.Point(27, 136);
            this.rd_Fill_Rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_Fill_Rectangle.Name = "rd_Fill_Rectangle";
            this.rd_Fill_Rectangle.Size = new System.Drawing.Size(123, 24);
            this.rd_Fill_Rectangle.TabIndex = 4;
            this.rd_Fill_Rectangle.TabStop = true;
            this.rd_Fill_Rectangle.Text = "Fill Rectangle";
            this.rd_Fill_Rectangle.UseVisualStyleBackColor = true;
            // 
            // rd_String
            // 
            this.rd_String.AutoSize = true;
            this.rd_String.Location = new System.Drawing.Point(212, 53);
            this.rd_String.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_String.Name = "rd_String";
            this.rd_String.Size = new System.Drawing.Size(69, 24);
            this.rd_String.TabIndex = 3;
            this.rd_String.TabStop = true;
            this.rd_String.Text = "String";
            this.rd_String.UseVisualStyleBackColor = true;
            // 
            // rd_Ellipse
            // 
            this.rd_Ellipse.AutoSize = true;
            this.rd_Ellipse.Location = new System.Drawing.Point(212, 89);
            this.rd_Ellipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_Ellipse.Name = "rd_Ellipse";
            this.rd_Ellipse.Size = new System.Drawing.Size(73, 24);
            this.rd_Ellipse.TabIndex = 2;
            this.rd_Ellipse.TabStop = true;
            this.rd_Ellipse.Text = "Ellipse";
            this.rd_Ellipse.UseVisualStyleBackColor = true;
            // 
            // rd_Fill_Ellipse
            // 
            this.rd_Fill_Ellipse.AutoSize = true;
            this.rd_Fill_Ellipse.Location = new System.Drawing.Point(212, 136);
            this.rd_Fill_Ellipse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_Fill_Ellipse.Name = "rd_Fill_Ellipse";
            this.rd_Fill_Ellipse.Size = new System.Drawing.Size(96, 24);
            this.rd_Fill_Ellipse.TabIndex = 1;
            this.rd_Fill_Ellipse.TabStop = true;
            this.rd_Fill_Ellipse.Text = "Fill Ellipse";
            this.rd_Fill_Ellipse.UseVisualStyleBackColor = true;
            // 
            // rdb_Line
            // 
            this.rdb_Line.AutoSize = true;
            this.rdb_Line.Location = new System.Drawing.Point(27, 53);
            this.rdb_Line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdb_Line.Name = "rdb_Line";
            this.rdb_Line.Size = new System.Drawing.Size(57, 24);
            this.rdb_Line.TabIndex = 0;
            this.rdb_Line.TabStop = true;
            this.rdb_Line.Text = "Line";
            this.rdb_Line.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 613);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.gb_Image.ResumeLayout(false);
            this.gb_Image.PerformLayout();
            this.gb_Draw.ResumeLayout(false);
            this.gb_Draw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PenWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.GroupBox gb_Image;
        private System.Windows.Forms.TextBox txb_Point_Y;
        private System.Windows.Forms.TextBox txb_Point_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Load_Image;
        private System.Windows.Forms.GroupBox gb_Draw;
        private System.Windows.Forms.NumericUpDown nud_PenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.RadioButton rd_Rectangle;
        private System.Windows.Forms.RadioButton rd_Fill_Rectangle;
        private System.Windows.Forms.RadioButton rd_String;
        private System.Windows.Forms.RadioButton rd_Ellipse;
        private System.Windows.Forms.RadioButton rd_Fill_Ellipse;
        private System.Windows.Forms.RadioButton rdb_Line;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi8
{
    public partial class Form1 : Form
    {

        int Point_X, Point_Y;
        OpenFileDialog odlg;
        ImageHandler imgHandler = new ImageHandler();
        double ZoomFactor = 0.5;

        public Form1()
        {
            InitializeComponent();
            odlg = new OpenFileDialog();
        }

        private void btn_Load_Image_Click(object sender, EventArgs e)
        {
            if (odlg.ShowDialog() == DialogResult.OK)
            {
                imgHandler.CurrentBitmap = (Bitmap)Bitmap.FromFile(odlg.FileName);
                imgHandler.BitmapPath = odlg.FileName;
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size(Convert.ToInt32(imgHandler.CurrentBitmap.Width * ZoomFactor),
                Convert.ToInt32(imgHandler.CurrentBitmap.Height * ZoomFactor));
                this.Invalidate();
            }
        }

        private void txb_Point_X_TextChanged(object sender, EventArgs e)
        {
            Point_X = Int32.Parse(txb_Point_X.Text);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(imgHandler.CurrentBitmap, new Rectangle(Point_X, Point_Y,
                Convert.ToInt32(imgHandler.CurrentBitmap.Width * ZoomFactor),
                Convert.ToInt32(imgHandler.CurrentBitmap.Height * ZoomFactor)));
        }

        Point _Begin = new Point(0, 0);
        Point _End = new Point(0, 0);
        Color MauVe = Color.Black;
        int Width = 1;

        private void txb_Point_Y_TextChanged(object sender, EventArgs e)
        {
            Point_Y = Int32.Parse(txb_Point_Y.Text);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                _End.X = e.X;
                _End.Y = e.Y;
                DrawPaint(MauVe);
                flag = false;
            }
        }

        bool flag = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            flag = true;
            _Begin.X = e.X;
            _Begin.Y = e.Y;
            _End.X = e.X;
            _End.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                DrawPaint(Color.White);
                _End.X = e.X;
                _End.Y = e.Y;
                DrawPaint(MauVe);
            }
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        void DrawPaint(Color c)
        {
            if (_Begin != _End)
            {
                Graphics g = CreateGraphics();
                Pen x = new Pen(c, Width);
                SolidBrush y = new SolidBrush(c);
                if (rdb_Line.Checked)
                {
                    g.DrawLine(x, _Begin, _End);
                }
                if (rd_Rectangle.Checked)
                {
                    float width = _End.X - _Begin.X;
                    float height = _End.Y - _Begin.Y;
                    if (width > 0 && height > 0)
                    {
                        g.DrawRectangle(x, _Begin.X, _Begin.Y, width, height);
                    }
                    if (width > 0 && height < 0)
                    {
                        g.DrawRectangle(x, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height < 0)
                    {
                        g.DrawRectangle(x, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height > 0)
                    {
                        g.DrawRectangle(x, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                    }
                }
                if (rd_Ellipse.Checked)
                {
                    float width = _End.X - _Begin.X;
                    float height = _End.Y - _Begin.Y;
                    if (width > 0 && height > 0)
                    {
                        g.DrawEllipse(x, _Begin.X, _Begin.Y, width, height);
                    }
                    if (width > 0 && height < 0)
                    {
                        g.DrawEllipse(x, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height < 0)
                    {
                        g.DrawEllipse(x, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height > 0)
                    {
                        g.DrawEllipse(x, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                    }
                }
                if (rd_Fill_Ellipse.Checked)
                {
                    SolidBrush b = new SolidBrush(c);
                    float width = _End.X - _Begin.X;
                    float height = _End.Y - _Begin.Y;
                    if (width > 0 && height > 0)
                    {
                        g.DrawEllipse(x, _Begin.X, _Begin.Y, width, height);
                        g.FillEllipse(b, _Begin.X, _Begin.Y, width, height);
                    }
                    if (width > 0 && height < 0)
                    {
                        g.DrawRectangle(x, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                        g.FillEllipse(b, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height < 0)
                    {
                        g.DrawRectangle(x, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                        g.FillEllipse(b, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height > 0)
                    {
                        g.DrawRectangle(x, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                        g.FillEllipse(b, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                    }
                }
                if (rd_Fill_Rectangle.Checked)
                {
                    SolidBrush b = new SolidBrush(c);
                    float width = _End.X - _Begin.X;
                    float height = _End.Y - _Begin.Y;
                    if (width > 0 && height > 0)
                    {
                        g.DrawRectangle(x, _Begin.X, _Begin.Y, width, height);
                        g.FillRectangle(b, _Begin.X, _Begin.Y, width, height);
                    }
                    if (width > 0 && height < 0)
                    {
                        g.DrawRectangle(x, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                        g.FillRectangle(b, _Begin.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height < 0)
                    {
                        g.DrawRectangle(x, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                        g.FillRectangle(b, _End.X, _End.Y, Math.Abs(width), Math.Abs(height));
                    }
                    if (width < 0 && height > 0)
                    {
                        g.DrawRectangle(x, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                        g.FillRectangle(b, _End.X, _Begin.Y, Math.Abs(width), Math.Abs(height));
                    }
                }


            }
        }
    }
}

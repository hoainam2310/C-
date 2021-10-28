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
          if(odlg.ShowDialog() == DialogResult.OK)
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

        private void txb_Point_Y_TextChanged(object sender, EventArgs e)
        {
            Point_Y = Int32.Parse(txb_Point_Y.Text);
        }

      
    }
}

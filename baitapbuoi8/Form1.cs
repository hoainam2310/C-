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
        bool Line_Check = false;
        bool Rectangle_Check = false;
        bool FillRectangle_Check = false;
        bool String_Check = false;
        bool Ellipse_Check = false;
        bool FillEllipse_Check = false;       

        public Form1()
        {
            InitializeComponent();
            int Point_X = Int32.Parse(txb_Point_X.Text);
            int Point_Y = Int32.Parse(txb_Point_Y.Text);
        }

        private void rd_Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            bool Rectangle_Check = true;
        }
    }
}

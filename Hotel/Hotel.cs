using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datphong
{
    public partial class Hotel : Form
    {
        DataTable dt = new DataTable();
        public Hotel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themphong_Click(object sender, EventArgs e)
        {
 
            string IDRoom = "";
            string TypeRoom = cbox_loaiphong.Text;
            if (TypeRoom == "A")
            {
                int A = 0;
                A++;
                IDRoom ="A"+A.ToString();
            }
            if (TypeRoom == "B")
            {
                int B = 0;
                B++;
                IDRoom = "B" + B.ToString();
            }
            if (TypeRoom == "A")
            {
                int C = 0;
                C++;
                IDRoom = "C" + C.ToString();
            }
            listView1.Items.Add(IDRoom, 2);
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }
    }
}

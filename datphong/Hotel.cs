﻿using System;
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

        private void btn_themphong_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("A1", 2);
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }
    }
}

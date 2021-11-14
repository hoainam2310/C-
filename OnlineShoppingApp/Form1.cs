using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineShoppingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_search_Click(object sender, EventArgs e)
        {
            txb_search.Text = "";
            txb_search.ForeColor = Color.Black;
        }

        private void bbtn_Laptop_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);    
        }

        private void bbtn_phukienlap_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_pc_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_maychoigame_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_mayin_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_tbimang_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_tbiluutru_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void bbtn_tbivanphongkhac_Click(object sender, EventArgs e)
        {
            pages.SetPage(((Control)sender).Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        int billprice = 0;

        private void p_lap1_Click(object sender, EventArgs e)
        {
            int lapprice1 = 38999000;
            billprice = billprice + 38999000;
            MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng !" + billprice);
        }

        private void pb_cart_Click(object sender, EventArgs e)
        {
            if(pl_cart.Visible==false)
            {
                pl_cart.Visible = true;
            }
            else
            {
                pl_cart.Visible = false;
            }  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

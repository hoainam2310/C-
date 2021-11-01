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
    public partial class ShopItems : Bunifu.UI.WinForms.BunifuUserControl
    {
        public ShopItems()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return itemimage.Image;
            }

            set
            {
                itemimage.Image = value;
            }
        }
        public string ItemID
        {
            get
            {
                return lb_itemID.Text;
            }

            set
            {
                lb_itemID.Text = value;
            }
        }
        public string ItemPrice
        {
            get
            {
                return lb_itemprice.Text;
            }

            set
            {
                lb_itemprice.Text = value;
            }
        }
    }
}

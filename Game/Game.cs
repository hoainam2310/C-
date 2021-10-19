using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi7
{
    public partial class f_game : Form
    {
        public f_game()
        {
            InitializeComponent();
        }

        private void f_game_KeyDown(object sender, KeyEventArgs e)
        {
            int istep = Convert.ToInt32(lb_step.Text);
            if(e.KeyCode == Keys.Up)
            {
                if(btn_1.BackColor==Color.White)
                {
                    btn_1.BackColor = btn_4.BackColor;
                    btn_4.BackColor = Color.White;
                }
                else if (btn_4.BackColor == Color.White)
                {
                    btn_4.BackColor = btn_7.BackColor;
                    btn_7.BackColor = Color.White;
                }
                else if (btn_2.BackColor == Color.White)
                {
                    btn_2.BackColor = btn_5.BackColor;
                    btn_5.BackColor = Color.White;
                }
                else if (btn_5.BackColor == Color.White)
                {
                    btn_5.BackColor = btn_8.BackColor;
                    btn_8.BackColor = Color.White;
                }
                else if (btn_3.BackColor == Color.White)
                {
                    btn_3.BackColor = btn_6.BackColor;
                    btn_6.BackColor = Color.White;
                }
                else if (btn_6.BackColor == Color.White)
                {
                    btn_6.BackColor = btn_9.BackColor;
                    btn_9.BackColor = Color.White;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (btn_9.BackColor == Color.White)
                {
                    btn_9.BackColor = btn_8.BackColor;
                    btn_8.BackColor = Color.White;
                }
                else if (btn_8.BackColor == Color.White)
                {
                    btn_8.BackColor = btn_7.BackColor;
                    btn_7.BackColor = Color.White;
                }
                else if (btn_6.BackColor == Color.White)
                {
                    btn_6.BackColor = btn_5.BackColor;
                    btn_5.BackColor = Color.White;
                }
                else if (btn_5.BackColor == Color.White)
                {
                    btn_5.BackColor = btn_4.BackColor;
                    btn_4.BackColor = Color.White;
                }
                else if (btn_3.BackColor == Color.White)
                {
                    btn_3.BackColor = btn_2.BackColor;
                    btn_2.BackColor = Color.White;
                }
                else if (btn_2.BackColor == Color.White)
                {
                    btn_2.BackColor = btn_1.BackColor;
                    btn_1.BackColor = Color.White;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (btn_7.BackColor == Color.White)
                {
                    btn_7.BackColor = btn_8.BackColor;
                    btn_8.BackColor = Color.White;
                }
                else if (btn_8.BackColor == Color.White)
                {
                    btn_8.BackColor = btn_9.BackColor;
                    btn_9.BackColor = Color.White;
                }
                else if (btn_4.BackColor == Color.White)
                {
                    btn_4.BackColor = btn_5.BackColor;
                    btn_5.BackColor = Color.White;
                }
                else if (btn_5.BackColor == Color.White)
                {
                    btn_5.BackColor = btn_6.BackColor;
                    btn_6.BackColor = Color.White;
                }
                else if (btn_1.BackColor == Color.White)
                {
                    btn_1.BackColor = btn_2.BackColor;
                    btn_2.BackColor = Color.White;
                }
                else if (btn_2.BackColor == Color.White)
                {
                    btn_2.BackColor = btn_3.BackColor;
                    btn_3.BackColor = Color.White;
                }
            }
            else if (e.KeyCode ==Keys.Down)
            {
                if(btn_7.BackColor==Color.White)
                {
                    btn_7.BackColor = btn_4.BackColor;
                    btn_4.BackColor = Color.White;
                }
                else if ( btn_4.BackColor==Color.White)
                {
                    btn_4.BackColor = btn_1.BackColor;
                    btn_1.BackColor = Color.White;
                }
                else if (btn_8.BackColor == Color.White)
                {
                    btn_8.BackColor = btn_5.BackColor;
                    btn_5.BackColor = Color.White;
                }
                else if (btn_5.BackColor == Color.White)
                {
                    btn_5.BackColor = btn_2.BackColor;
                    btn_2.BackColor = Color.White;
                }
                else if (btn_9.BackColor == Color.White)
                {
                    btn_9.BackColor = btn_6.BackColor;
                    btn_6.BackColor = Color.White;
                }
                else if (btn_6.BackColor == Color.White)
                {
                    btn_6.BackColor = btn_3.BackColor;
                    btn_3.BackColor = Color.White;
                }
            }
            istep = istep + 1;
            string strstep = istep.ToString();
            lb_step.Text = strstep;
        }
    }
    
}

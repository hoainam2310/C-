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

        private void p_start_Click(object sender, EventArgs e)
        {
            //hàm random trả về kết quả random trong khoảng (1,10)
            Random img_example = new Random();
            int flag = img_example.Next(1, 10);

            btn_1.BackColor = Color.Green;
            btn_2.BackColor = Color.Blue;
            btn_3.BackColor = Color.Red;
            btn_4.BackColor = Color.Blue;
            btn_5.BackColor = Color.Green;
            btn_6.BackColor = Color.Blue;
            btn_7.BackColor = Color.White;
            btn_8.BackColor = Color.Red;
            btn_9.BackColor = Color.Green;



            if (flag == 1)
            {
                picb_img_example1.Visible = true;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 2)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = true;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 3)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = true;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 4)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = true;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 5)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = true;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 6)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = true;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 7)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = true;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 8)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = true;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = false;
            }
            if (flag == 9)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = true;
                picb_img_example10.Visible = false;
            }
            if (flag == 10)
            {
                picb_img_example1.Visible = false;
                picb_img_example2.Visible = false;
                picb_img_example3.Visible = false;
                picb_img_example4.Visible = false;
                picb_img_example5.Visible = false;
                picb_img_example6.Visible = false;
                picb_img_example7.Visible = false;
                picb_img_example8.Visible = false;
                picb_img_example9.Visible = false;
                picb_img_example10.Visible = true;
            }


        }

        private void l_start_Click(object sender, EventArgs e)
        {
            p_start_Click(sender, e);
        }

        private void picb_start_Click(object sender, EventArgs e)
        {
            p_start_Click(sender, e);
        }
    }
    
}

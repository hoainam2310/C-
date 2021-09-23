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
            //thêm các cột của datatable dt
            dt.Columns.Add("Ma", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("Gia", typeof(double));
            dt.Columns.Add("TT", typeof(string));
            dt.Columns.Add("Ngay", typeof(int));
        }

        int A = 0, B = 0, C = 0;

        private void btn_datphong_Click(object sender, EventArgs e)
        {          
            string s = "Ma='" + txt_maphong.Text + "'";
            DataRow[] dr = dt.Select(s);
            for(int i = 0; i < dt.Rows.Count; i++)
                if(dt.Rows[i]["Ma"].ToString() == txt_maphong.Text)
                {
                    //Muốn đặt phòng thì số ngày ở phải lớn hơn 0
                    if (nud_songayo.Value > 0)
                    {
                        dt.Rows[i]["Ngay"] = nud_songayo.Value;
                        dt.Rows[i]["TT"] = "Đầy";
                        rb_day.Checked = true;
                        MessageBox.Show("Bạn đã đặt phòng thành công!", "THÔNG BÁO!");
                    }
                    else
                        MessageBox.Show("Bạn chưa nhập số ngày ở!", "THÔNG BÁO!");
                        
                }
        }

        private void btn_huyphong_Click(object sender, EventArgs e)
        {
            string s = "Ma='" + txt_maphong.Text + "'";
            DataRow[] dr = dr = dt.Select(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Ma"].ToString() == txt_maphong.Text)
                {
                    dt.Rows[i]["Ngay"] = 0;
                    dt.Rows[i]["TT"] = "Trống";
                }
            }
            nud_songayo.Value = 0;
            rb_trong.Checked = true;
            MessageBox.Show("Hủy phòng thành công!", "THÔNG BÁO!");
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string tienthanhtoan = "Vui lòng thanh toán : " + Convert.ToInt32(txt_giaphong.Text) * nud_songayo.Value + " VNĐ"; 
            MessageBox.Show(tienthanhtoan, "THÔNG BÁO!");
            string s = "Ma='" + txt_maphong.Text + "'";
            DataRow[] dr = dr = dt.Select(s);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["Ma"].ToString() == txt_maphong.Text)
                {
                    dt.Rows[i]["Ngay"] = 0;
                    dt.Rows[i]["TT"] = "Trống";
                }
            }
            nud_songayo.Value = 0;
            rb_trong.Checked = true;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Lấy 1 dòng data trong datatable
            //Gán lại giá trị trong datatable của từng item cho bảng thông tin
            string s = "Ma='" + e.Item.Text + "'";
            DataRow[] dr = dt.Select(s);
            txt_maphong.Text = dr[0]["Ma"].ToString();
            cbox_loaiphong.Text = dr[0]["Loai"].ToString();
            txt_giaphong.Text = dr[0]["Gia"].ToString();
            if (dr[0]["TT"].ToString() == "Trống")
            {
                rb_trong.Checked = true;              
            }    
              
            else
            {
                rb_day.Checked = true;                
            }    
                
            nud_songayo.Value = Convert.ToDecimal(dr[0]["Ngay"]);

            if(rb_trong.Checked == true)
            {
                //Nếu phòng đang trống thì button hủy phòng và thanh toán không hoạt động
                btn_datphong.Enabled = true;
                btn_huyphong.Enabled = false;
                btn_thanhtoan.Enabled = false;
                listView1.Items[e.ItemIndex].BackColor = Color.White;
            }    
            else
            {
                btn_datphong.Enabled = false;
                btn_huyphong.Enabled = true;
                btn_thanhtoan.Enabled = true;
                listView1.Items[e.ItemIndex].BackColor = Color.Red;
            }    
   
        }

        private void btn_themphong_Click(object sender, EventArgs e)
        {
            //Khi ấn thêm phòng, mã phòng tăng tự động theo loại phòng
            if (string.Equals(cbox_loaiphong.Text, "A"))
            {
                A++;
                txt_maphong.Text = 'A' + A.ToString();
                string tienphong = "150000";
                txt_giaphong.Text = tienphong;
                dt.Rows.Add(txt_maphong.Text, cbox_loaiphong.Text, Convert.ToDouble(txt_giaphong.Text), rb_day.Checked == true ? "Đầy" : "Trống", Convert.ToInt32(nud_songayo.Value));
            }
            if (string.Equals(cbox_loaiphong.Text, "B"))
            {
                B++;
                txt_maphong.Text = 'B' + B.ToString();
                string tienphong = "250000";
                txt_giaphong.Text = tienphong;
                dt.Rows.Add(txt_maphong.Text, cbox_loaiphong.Text, Convert.ToDouble(txt_giaphong.Text), rb_day.Checked == true ? "Đầy" : "Trống", Convert.ToInt32(nud_songayo.Value));
            }
            if (string.Equals(cbox_loaiphong.Text, "C"))
            {
                C++;
                txt_maphong.Text = 'C' + C.ToString();
                string tienphong = "350000";
                txt_giaphong.Text = tienphong;
                dt.Rows.Add(txt_maphong.Text, cbox_loaiphong.Text, Convert.ToDouble(txt_giaphong.Text), rb_day.Checked == true ? "Đầy" : "Trống", Convert.ToInt32(nud_songayo.Value));
            }

            listView1.Items.Add(txt_maphong.Text, 2);
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }
        
    }
}

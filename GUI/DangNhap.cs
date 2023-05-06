using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txtmk.PasswordChar = '*'; //ẩn mật khẩu
            lbdn.Text = "";
            lbmk.Text = "";
        }
        //trả về kết quả
        NguoiDungBUS ndbus = new NguoiDungBUS();
        private void btndn_Click(object sender, EventArgs e)
        {
            NguoiDung u = new NguoiDung(txtten.Text, BaoMat.SaltedHash(txtmk.Text));
            string sql = "select * from NguoiDung where Taikhoan= N'" + txtten.Text + "' and MatKhau = N'" + BaoMat.SaltedHash(txtmk.Text) + "'";
            DataTable dt= ndbus.DatagvFind(sql);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập hệ thống thành công!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                TrangChu f = new TrangChu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString());
                f.Show();
            }
            else
                MessageBox.Show("Đăng nhập thất bại! ");
            /*if (ndbus.CheckLogin(u))
            {
                MessageBox.Show("Đăng nhập hệ thống thành công! ");
                this.Hide();
                TrangChu lg = new TrangChu();
                lg.ShowDialog();
                this.Close();
            }
            else
                    MessageBox.Show("Đăng nhập thất bại! "); */

        }
        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cbmk.Checked)
                    txtmk.PasswordChar = '\0';
                if (!cbmk.Checked)
                    txtmk.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //ẩn đi trang đăng nhập
            QuenMatKhau lg = new QuenMatKhau();
            lg.ShowDialog();
            this.Close();
        }

        private void btnmk_leave(object sender, EventArgs e)
        {
            String u = txtmk.Text;
            if (u.Trim() == "")
            {
                lbmk.Text = "Vui lòng nhập mật khẩu.";
                txtmk.Focus();
            }
            else
            {
                lbmk.Text = "";
            }
        }

        private void btndn_leave(object sender, EventArgs e)
        {
            String u = txtten.Text;
            if (u.Trim() == "")
            {
                lbdn.Text = "Vui lòng nhập tên tài khoản.";
                txtten.Focus();
            }
            else
            {
                lbdn.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

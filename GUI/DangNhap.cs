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
            NguoiDung u = new NguoiDung(txtten.Text, txtmk.Text);
            if (ndbus.CheckLogin(u))
            {
                MessageBox.Show("Đăng nhập hệ thống thành công! ");
                this.Hide();
                TrangChu lg = new TrangChu();
                lg.ShowDialog();
                this.Close();
            }
            else
                    MessageBox.Show("Đăng nhập thất bại! ");
            
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
    }
}

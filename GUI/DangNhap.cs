using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
        //trả về kết quả
        NguoiDungBUS ndbus = new NguoiDungBUS();
        private void btndn_Click(object sender, EventArgs e)
        {
            string ten= txtten.Text;
            string matkhau= txtmk.Text;
            NguoiDung u = new NguoiDung(txtten.Text,txtmk.Text);
            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                txtten.Focus();
            }
            else if (matkhau == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtmk.Focus();
            }
            else
            {
                if (ndbus.CheckLogin(u))
                {
                    MessageBox.Show("Đăng nhập hệ thống thành công! ");
                }
                else
                    MessageBox.Show("Đăng nhập thất bại! ");
            }
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
            QuenMatKhau lg = new QuenMatKhau();
            lg.ShowDialog();
        }
    }
}

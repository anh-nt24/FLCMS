using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            //captcha mới hiện lên mỗi khi tải trang 
            lbcaptcha.Text = BaoMat.Macaptcha();
            lbemail.Text = "";
            lbnote.Text = "";
            btndoimk.Enabled = false;

            //ẩn captcha và mật khẩu
            captcha.Hide();
            matkhau.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbcaptcha.Text= BaoMat.Macaptcha(); 

        }
        NguoiDungBUS ndbus = new NguoiDungBUS();
        private void button2_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtemail.Text);
            if (!match.Success)
            {
                MessageBox.Show("Email không hợp lệ!");
                txtemail.Focus();

            }
            else
            {
                NguoiDung u = new NguoiDung(txtemail.Text);
                if (ndbus.CheckEmail(u))
                {
                    captcha.Show();
                    matkhau.Hide();
                }
                else
                {
                    MessageBox.Show("Email chưa được đăng ký!");
                    captcha.Hide();
                    matkhau.Hide();
                }
            }

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            if (txtcaptcha.Text== lbcaptcha.Text) 
            {
                MessageBox.Show("Mã xác nhận đúng.");
                matkhau.Show();
            }
            else
            {
                matkhau.Hide();
                MessageBox.Show("Nhập sai mã xác nhận.");
                txtcaptcha.Text = "";
                //captcha mới mỗi khi nhập sai mã captcha
                lbcaptcha.Text = BaoMat.Macaptcha();
            }
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            String pw = BaoMat.SaltedHash(txtmk1.Text);
            String pwn = BaoMat.SaltedHash(txtmk2.Text);
            NguoiDung u = new NguoiDung("", pw, txtemail.Text);
            if (ndbus.Checkmkmoitrungmkcu(u))
            {
                MessageBox.Show("Mật khẩu trùng mật khẩu cũ!");
            }
            else if (pw != pwn)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống nhau");
            }
            else
            {
                ndbus.Thaydoimk(u);
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                this.Hide();
                DangNhap lg = new DangNhap();
                lg.ShowDialog();
                this.Close();
            }

        }

        private void txtmk1_leave(object sender, EventArgs e)
        {
            String u = txtmk1.Text;
            if (u.Length <= 6)
            {
                lbnote.Text="Mật khẩu phải nhiều hơn 6 kí tự.";
                btndoimk.Enabled = false;
                txtmk1.Focus();
            } else
            {
                lbnote.Text = "";
                btndoimk.Enabled = true;

            }
        }
    }
}

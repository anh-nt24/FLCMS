using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class ThayDoiMatKhau : Form
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
            lbnote.Text = "";
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";
        NguoiDungBUS ndbus = new NguoiDungBUS();

        private void btndoimk_Click(object sender, EventArgs e)
        {
            String pw = BaoMat.SaltedHash(txtmk1.Text);
            String pwn = BaoMat.SaltedHash(txtmk2.Text);
            NguoiDung u = new NguoiDung("", pw,"");
            if (pw==MatKhau)
            {
                MessageBox.Show("Mật khẩu trùng mật khẩu cũ!");
            }
            else if (pw != pwn)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống nhau");
            }
            else
            {
                ndbus.Thaydoimkkodk(u);
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
            if (u.Length < 6)
            {
                lbnote.Text = "Mật khẩu phải nhiều hơn 6 kí tự.";
                btndoimk.Enabled = false;
                txtmk1.Focus();
            }
            else
            {
                lbnote.Text = "";
                btndoimk.Enabled = true;

            }
        }

        public ThayDoiMatKhau(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
        {
            InitializeComponent();
            this.MaND = mand;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.Sdt = sdt;
            this.Taikhoan = taikhoan;
            this.MatKhau = matkhau;
            this.Quyen = quyen;
            this.NgaySinh = ngaysinh;
            this.ViTriLamViec = vitrivieclam;
            this.Email = email;
            lbnote.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu lg = new TrangChu(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();    
        }
        string Taikhoan = "", MatKhau = "", Quyen = "",MaND="",HoTen="",DiaChi="",Sdt="",NgaySinh="",ViTriLamViec="",Email="";
        public TrangChu(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            txtten.Text = "Xin Chào " + Quyen + "";
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void qlhv1_Load(object sender, EventArgs e)
        {

        }
        private void btnbaocao_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap lg = new DangNhap();
            lg.ShowDialog();
            this.Close();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Quyen == "Admin")
            {
                this.Hide();
                QuanLiNguoiDung lg = new QuanLiNguoiDung(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
                lg.ShowDialog();
            } else
            {
                MessageBox.Show(""+Quyen+ "' không có quyền này!");
            }
        }

        private void kìThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiKiThi lg = new QuanLiKiThi(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void txtten_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiMatKhau lg = new ThayDoiMatKhau(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void họcViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachHocVien lg = new DanhSachHocVien(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void danhSáchGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachGiaoVien lg = new DanhSachGiaoVien(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void danhSáchKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachKhoaHoc lg = new DanhSachKhoaHoc(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void chứngNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiChungNhan lg = new QuanLiChungNhan(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiHocVien lg = new QuanLiHocVien(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void điểmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiDiemThi lg = new QuanLiDiemThi(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiHopDong lg = new QuanLiHopDong(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiLopHoc lg = new QuanLiLopHoc(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void khóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiKhoaHoc lg = new QuanLiKhoaHoc(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void xemThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinCaNhan f = new ThongTinCaNhan(MaND,HoTen,DiaChi,Sdt,Taikhoan,MatKhau,Quyen,NgaySinh,ViTriLamViec,Email);
            f.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLiGiaoVien lg = new QuanLiGiaoVien(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

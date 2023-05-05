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

namespace GUI
{
    public partial class QuanLiNguoiDung : Form
    {
        public QuanLiNguoiDung()
        {
            InitializeComponent();
            dgvnd.DataSource = ndbus.DatagvDAL();
            txtmand.Enabled = false;
            txttaikhoan.Enabled = false;
            txtmk.Enabled = false;
            //load combobox hoten ở find
            cbten.DisplayMember = "HoTen";
            string sql = "select HoTen from NguoiDung";
            cbten.DataSource = ndbus.LoadComboBox(sql);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiNguoiDung(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            dgvnd.DataSource = ndbus.DatagvDAL();
            txtmand.Enabled = false;
            txttaikhoan.Enabled = false;
            txtmk.Enabled = false;
            //load combobox hoten ở find
            cbten.DisplayMember = "HoTen";
            string sql = "select HoTen from NguoiDung";
            cbten.DataSource = ndbus.LoadComboBox(sql);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        NguoiDungBUS ndbus = new NguoiDungBUS();

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttaikhoan.Text = BaoMat.Mataikhoan();
            txtmk.Text = "01234567"; //mật khẩu mặc định, người dùng đăng nhập vào lần đầu tiên r tự đổi
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmk.Text;
            string quyen = cbquyen.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string chucvu = cbchucvu.Text;
            string email = txtemail.Text;
            if (hoten.Equals("") || diachi.Equals("") || sdt.Equals("") || taikhoan.Equals("") || matkhau.Equals("") || quyen.Equals("") || chucvu.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvnd.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0)
                {
                    txtmand.Text = "MaND001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvnd.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmand.Text = "MaND00" + (so + 1).ToString();//cộng dồn lên khi thỏa mãn if
                    else if (so + 1 < 100)
                        txtmand.Text = "MaND0" + (so + 1).ToString();
                }
                //ktra email hợp lệ k
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txtemail.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Email không hợp lệ!");
                    txtemail.Focus();
                }
                else
                {
                    NguoiDung u = new NguoiDung(txtmand.Text, hoten, diachi, sdt, taikhoan, BaoMat.SaltedHash(matkhau), quyen, ngaysinh, chucvu, email);
                    if (ndbus.ChecktontaiTaiKhoan(u))
                    {
                        txttaikhoan.Text = BaoMat.Mataikhoan();
                    }
                    else if (ndbus.ChecktontaiEmail(u))
                    {
                        MessageBox.Show("Email đã tồn tại trong hệ thống!");
                        txtemail.Focus();
                    }
                    else
                    {
                        ndbus.InsertND(u);
                        MessageBox.Show("Thêm người dùng thành công!");
                        txtmand.Text = "";
                        txthoten.Text = "";
                        txtdiachi.Text = "";
                        txtsdt.Text = "";
                        txttaikhoan.Text = "";
                        txtmk.Text = "";
                        cbquyen.Text = "";
                        txtngaysinh.Text = "";
                        cbchucvu.Text = "";
                        txtemail.Text = "";
                        cbten.DisplayMember = "HoTen";
                        string sql = "select HoTen from NguoiDung";
                        cbten.DataSource = ndbus.LoadComboBox(sql);
                    }

                }
            }

            dgvnd.DataSource = ndbus.DatagvDAL();
        }

        private void dgvnd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmand.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvnd.Rows[indexofcontent];
            txtmand.Text = dataGridViewRow.Cells[0].Value.ToString();
            txthoten.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtsdt.Text = dataGridViewRow.Cells[3].Value.ToString();
            txttaikhoan.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtmk.Text = dataGridViewRow.Cells[5].Value.ToString();
            cbquyen.Text = dataGridViewRow.Cells[6].Value.ToString();
            txtngaysinh.Text = dataGridViewRow.Cells[7].Value.ToString();
            cbchucvu.Text = dataGridViewRow.Cells[8].Value.ToString();
            txtemail.Text = dataGridViewRow.Cells[9].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }



        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmand.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttaikhoan.Text = "";
            txtmk.Text = "";
            cbquyen.Text = "";
            txtngaysinh.Text = "";
            cbchucvu.Text = "";
            txtemail.Text = "";
            dgvnd.DataSource = ndbus.DatagvDAL();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mand = txtmand.Text;
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmk.Text;
            string quyen = cbquyen.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string chucvu = cbchucvu.Text;
            string email = txtemail.Text;
            NguoiDung u = new NguoiDung(mand, hoten, diachi, sdt, taikhoan, matkhau, quyen, ngaysinh, chucvu, email);
            ndbus.UpdateND(u);
            MessageBox.Show("Chỉnh sửa thành công!");
            dgvnd.DataSource = ndbus.DatagvDAL();
            txtmand.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttaikhoan.Text = "";
            txtmk.Text = "";
            cbquyen.Text = "";
            txtngaysinh.Text = "";
            cbchucvu.Text = "";
            txtemail.Text = "";
            cbten.DisplayMember = "HoTen";
            string sql = "select HoTen from NguoiDung";
            cbten.DataSource = ndbus.LoadComboBox(sql);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mand = txtmand.Text;
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmk.Text;
            string quyen = cbquyen.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string chucvu = cbchucvu.Text;
            string email = txtemail.Text;
            NguoiDung u = new NguoiDung(mand, hoten, diachi, sdt, taikhoan, matkhau, quyen, ngaysinh, chucvu, email);
            ndbus.DeleteND(u);
            MessageBox.Show("Xóa người dùng thành công!");
            dgvnd.DataSource = ndbus.DatagvDAL();
            txtmand.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttaikhoan.Text = "";
            txtmk.Text = "";
            cbquyen.Text = "";
            txtngaysinh.Text = "";
            cbchucvu.Text = "";
            txtemail.Text = "";
            cbten.DisplayMember = "HoTen";
            string sql = "select HoTen from NguoiDung";
            cbten.DataSource = ndbus.LoadComboBox(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //tìm kiếm thì load lại dgv
            string sql = "select * from NguoiDung where HoTen= N'" + cbten.Text + "'";
            dgvnd.DataSource = ndbus.DatagvFind(sql);
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

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
    public partial class QuanLiKhoaHoc : Form
    {
        public QuanLiKhoaHoc()
        {
            InitializeComponent();
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
            txtmakh.Enabled = false;
            cbten.DisplayMember = "TenKhoaHoc";
            string sql1 = "select TenKhoaHoc from KhoaHoc";
            cbten.DataSource = khbus.LoadComboBox(sql1);
            cbmalop.DisplayMember = "MaLop";
            string sql2 = "select MaLop from LopHoc";
            cbmalop.DataSource = khbus.LoadComboBox(sql2);
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiKhoaHoc(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
            txtmakh.Enabled = false;
            cbten.DisplayMember = "TenKhoaHoc";
            string sql1 = "select TenKhoaHoc from KhoaHoc";
            cbten.DataSource = khbus.LoadComboBox(sql1);
            cbmalop.DisplayMember = "MaLop";
            string sql2 = "select MaLop from LopHoc";
            cbmalop.DataSource = khbus.LoadComboBox(sql2);
        }
        KhoaHocBUS khbus = new KhoaHocBUS();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string capdo = txtcapdo.Text;
            string sobuoi = txtsobuoi.Text;
            string hocphi = txthocphi.Text;
            string malop = cbmalop.Text;

            if (ten.Equals("") || capdo.Equals("") || sobuoi.Equals("") || hocphi.Equals("") || malop.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvkh.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmakh.Text = "MaKH001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvkh.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmakh.Text = "MaKH00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmakh.Text = "MaKH0" + (so + 1).ToString();
                }
                KhoaHoc u = new KhoaHoc(txtmakh.Text, ten, capdo, sobuoi, hocphi, malop);
                khbus.InsertKH(u);
                MessageBox.Show("Thêm khóa học thành công!");
                txtmakh.Text = "";
                txtten.Text = "";
                txtcapdo.Text = "";
                txtsobuoi.Text = "";
                txthocphi.Text = "";
                cbmalop.Text = "";
                cbten.DisplayMember = "TenKhoaHoc";
                string sql1 = "select TenKhoaHoc from KhoaHoc";
                cbten.DataSource = khbus.LoadComboBox(sql1);
            }
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string makh = txtmakh.Text;
            string ten = txtten.Text;
            string capdo = txtcapdo.Text;
            string sobuoi = txtsobuoi.Text;
            string hocphi = txthocphi.Text;
            string malop = cbmalop.Text;
            KhoaHoc u = new KhoaHoc(makh, ten, capdo, sobuoi, hocphi, malop);
            khbus.UpdateKH(u);
            MessageBox.Show("Chỉnh sửa khóa học thành công!");
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
            txtmakh.Text = "";
            txtten.Text = "";
            txtcapdo.Text = "";
            txtsobuoi.Text = "";
            txthocphi.Text = "";
            cbmalop.Text = "";
            cbten.DisplayMember = "TenKhoaHoc";
            string sql1 = "select TenKhoaHoc from KhoaHoc";
            cbten.DataSource = khbus.LoadComboBox(sql1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string makh = txtmakh.Text;
            string ten = txtten.Text;
            string capdo = txtcapdo.Text;
            string sobuoi = txtsobuoi.Text;
            string hocphi = txthocphi.Text;
            string malop = cbmalop.Text;
            KhoaHoc u = new KhoaHoc(makh, ten, capdo, sobuoi, hocphi, malop);
            khbus.DeleteKH(u);
            MessageBox.Show("Xóa khóa học thành công!");
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
            txtmakh.Text = "";
            txtten.Text = "";
            txtcapdo.Text = "";
            txtsobuoi.Text = "";
            txthocphi.Text = "";
            cbmalop.Text = "";
            cbten.DisplayMember = "TenKhoaHoc";
            string sql1 = "select TenKhoaHoc from KhoaHoc";
            cbten.DataSource = khbus.LoadComboBox(sql1);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txtten.Text = "";
            txtcapdo.Text = "";
            txtsobuoi.Text = "";
            txthocphi.Text = "";
            cbmalop.Text = "";
            string sql = "select * from KhoaHoc";
            dgvkh.DataSource = khbus.DatagvFind(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from KhoaHoc where TenKhoaHoc = N'" + cbten.Text + "'";
            dgvkh.DataSource = khbus.DatagvFind(sql);
        }

        private void dgvkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvkh.Rows[indexofcontent];
            txtmakh.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtten.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtcapdo.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtsobuoi.Text = dataGridViewRow.Cells[3].Value.ToString();
            txthocphi.Text = dataGridViewRow.Cells[4].Value.ToString();
            cbmalop.Text = dataGridViewRow.Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu lg = new TrangChu(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
            this.Close();
        }

        private void btnhd_Click(object sender, EventArgs e)
        {
            QuanLiLopHoc lg = new QuanLiLopHoc(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }
    }
}

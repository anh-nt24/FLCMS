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

namespace GUI
{
    public partial class QuanLiLopHoc : Form
    {
        public QuanLiLopHoc()
        {
            InitializeComponent();
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
            txtmalh.Enabled = false;
            cbten.DisplayMember = "TenLop";
            string sql1 = "select TenLop from LopHoc";
            cbten.DataSource = lhbus.LoadComboBox(sql1);
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiLopHoc(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
            txtmalh.Enabled = false;
            cbten.DisplayMember = "TenLop";
            string sql1 = "select TenLop from LopHoc";
            cbten.DataSource = lhbus.LoadComboBox(sql1);
        }
        LopHocBUS lhbus = new LopHocBUS();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string tenph = cbphong.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            if (ten.Equals("") || tenph.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvlh.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmalh.Text = "MaLH001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvlh.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmalh.Text = "MaLH00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmalh.Text = "MaLH0" + (so + 1).ToString();
                }
                LopHoc u = new LopHoc(txtmalh.Text, ten, tenph, ngaybd);
                lhbus.InsertLH(u);
                MessageBox.Show("Thêm lớp học thành công!");
                txtmalh.Text = "";
                txtten.Text = "";
                cbphong.Text = "";
                txtngaybd.Text = "";
                cbten.DisplayMember = "TenLop";
                string sql1 = "select TenLop from LopHoc";
                cbten.DataSource = lhbus.LoadComboBox(sql1);
            }
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
        }

        private void dgvlh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmalh.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvlh.Rows[indexofcontent];
            txtmalh.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtten.Text = dataGridViewRow.Cells[1].Value.ToString();
            cbphong.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtngaybd.Text = dataGridViewRow.Cells[3].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string malh = txtmalh.Text;
            string ten = txtten.Text;
            string tenph = cbphong.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            LopHoc u = new LopHoc(malh, ten, tenph, ngaybd);
            lhbus.UpdateLH(u);
            MessageBox.Show("Chỉnh sửa lớp học thành công!");
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
            txtmalh.Text = "";
            txtten.Text = "";
            cbphong.Text = "";
            txtngaybd.Text = "";
            cbten.DisplayMember = "TenLop";
            string sql1 = "select TenLop from LopHoc";
            cbten.DataSource = lhbus.LoadComboBox(sql1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string malh = txtmalh.Text;
            string ten = txtten.Text;
            string tenph = cbphong.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            LopHoc u = new LopHoc(malh, ten, tenph, ngaybd);
            lhbus.DeleteLH(u);
            MessageBox.Show("Xóa lớp học thành công!");
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
            txtmalh.Text = "";
            txtten.Text = "";
            cbphong.Text = "";
            txtngaybd.Text = "";
            cbten.DisplayMember = "TenLop";
            string sql1 = "select TenLop from LopHoc";
            cbten.DataSource = lhbus.LoadComboBox(sql1);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmalh.Text = "";
            txtten.Text = "";
            cbphong.Text = "";
            txtngaybd.Text = "";
            string sql = "select * from LopHoc";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from LopHoc where TenLop = N'" + cbten.Text + "'";
            dgvlh.DataSource = lhbus.DatagvFind(sql);
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

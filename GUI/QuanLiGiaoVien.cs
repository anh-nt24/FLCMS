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
    public partial class QuanLiGiaoVien : Form
    {
        public QuanLiGiaoVien()
        {
            InitializeComponent();
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
            txtmagv.Enabled = false;
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from GiaoVien";
            cbten.DataSource = gvbus.LoadComboBox(sql1);
            cbhd.DisplayMember = "MaHopDong";
            string sql2 = "select MaHopDong from HopDong";
            cbhd.DataSource = gvbus.LoadComboBox(sql2);
            cbmalop.DisplayMember = "MaLop";
            string sql3 = "select MaLop from LopHoc";
            cbmalop.DataSource = gvbus.LoadComboBox(sql3);
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiGiaoVien(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
            txtmagv.Enabled = false;
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from GiaoVien";
            cbten.DataSource = gvbus.LoadComboBox(sql1);
            cbhd.DisplayMember = "MaHopDong";
            string sql2 = "select MaHopDong from HopDong";
            cbhd.DataSource = gvbus.LoadComboBox(sql2);
            cbmalop.DisplayMember = "MaLop";
            string sql3 = "select MaLop from LopHoc";
            cbmalop.DataSource = gvbus.LoadComboBox(sql3);
        }
        GiaoVienBUS gvbus = new GiaoVienBUS();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txthoten.Text;
            string diachi=txtdiachi.Text;
            string sdt= txtsdt.Text;
            string ngaysinh= txtngaysinh.Value.ToString("yyyy-MM-dd");
            string ngayvl = txtnvl.Value.ToString("yyyy-MM-dd");
            string chuyenmon = txtcm.Text;
            string bangcap = txtbc.Text;
            string mahd = cbhd.Text;
            string malop = cbmalop.Text;

            if (ten.Equals("") || diachi.Equals("") || sdt.Equals("") || chuyenmon.Equals("") || bangcap.Equals("") || mahd.Equals("") || malop.Equals(""))
            { 
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvgv.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmagv.Text = "MaGV001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvgv.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmagv.Text = "MaGV00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmagv.Text = "MaGV0" + (so + 1).ToString();
                }
                GiaoVien u = new GiaoVien(txtmagv.Text, ten, diachi,sdt,ngaysinh,ngayvl,chuyenmon,bangcap,mahd,malop);
                gvbus.InsertGV(u);
                MessageBox.Show("Thêm giáo viên thành công!");
                txtmagv.Text = "";
                txthoten.Text = "";
                txtdiachi.Text = "";
                txtngaysinh.Text = "";
                txtcm.Text = "";
                txtbc.Text = "";
                cbmalop.Text = "";
                cbhd.Text = "";
                cbten.DisplayMember = "HoTen";
                string sql1 = "select HoTen from GiaoVien";
                cbten.DataSource = gvbus.LoadComboBox(sql1);
            }
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
        }

        private void btnhd_Click(object sender, EventArgs e)
        {
            QuanLiHopDong lg = new QuanLiHopDong(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void btnlop_Click(object sender, EventArgs e)
        {
            QuanLiLopHoc lg = new QuanLiLopHoc(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string magv=txtmagv.Text;
            string ten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string ngayvl = txtnvl.Value.ToString("yyyy-MM-dd");
            string chuyenmon = txtcm.Text;
            string bangcap = txtbc.Text;
            string mahd = cbhd.Text;
            string malop = cbmalop.Text;
            GiaoVien u = new GiaoVien(magv, ten, diachi, sdt, ngaysinh, ngayvl, chuyenmon, bangcap, mahd, malop);
            gvbus.UpdateGV(u);
            MessageBox.Show("Chỉnh sửa giáo viên thành công!");
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
            txtmagv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtngaysinh.Text = "";
            txtnvl.Text = "";
            txtcm.Text = "";
            txtbc.Text = "";
            cbmalop.Text = "";
            cbhd.Text = "";
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from GiaoVien";
            cbten.DataSource = gvbus.LoadComboBox(sql1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string magv = txtmagv.Text;
            string ten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string ngayvl = txtnvl.Value.ToString("yyyy-MM-dd");
            string chuyenmon = txtcm.Text;
            string bangcap = txtbc.Text;
            string mahd = cbhd.Text;
            string malop = cbmalop.Text;
            GiaoVien u = new GiaoVien(magv, ten, diachi, sdt, ngaysinh, ngayvl, chuyenmon, bangcap, mahd, malop);
            gvbus.DeleteGV(u);
            MessageBox.Show("Xóa giáo viên thành công!");
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
            txtmagv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtngaysinh.Text = "";
            txtnvl.Text = "";
            txtcm.Text = "";
            txtbc.Text = "";
            cbmalop.Text = "";
            cbhd.Text = "";
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from GiaoVien";
            cbten.DataSource = gvbus.LoadComboBox(sql1);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmagv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtngaysinh.Text = "";
            txtnvl.Text = "";
            txtcm.Text = "";
            txtbc.Text = "";
            cbmalop.Text = "";
            cbhd.Text = "";
            string sql = "select * from GiaoVien";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from GiaoVien where HoTen = N'" + cbten.Text + "'";
            dgvgv.DataSource = gvbus.DatagvFind(sql);
        }

        private void dgvgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmagv.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvgv.Rows[indexofcontent];
            txtmagv.Text = dataGridViewRow.Cells[0].Value.ToString();
            txthoten.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtsdt.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtngaysinh.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtnvl.Text = dataGridViewRow.Cells[5].Value.ToString();
            txtcm.Text = dataGridViewRow.Cells[6].Value.ToString();
            txtbc.Text = dataGridViewRow.Cells[7].Value.ToString();
            cbhd.Text = dataGridViewRow.Cells[8].Value.ToString();
            cbmalop.Text = dataGridViewRow.Cells[9].Value.ToString();
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

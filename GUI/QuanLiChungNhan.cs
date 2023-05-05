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
    public partial class QuanLiChungNhan : Form
    {
        public QuanLiChungNhan()
        {
            InitializeComponent();
            string sql = "select * from ChungNhan";
            dgvcn.DataSource = cnbus.DatagvFind(sql);
            txtmacn.Enabled = false;
            cbten.DisplayMember = "TenChungNhan";
            string sql1 = "select TenChungNhan from ChungNhan";
            cbten.DataSource = cnbus.LoadComboBox(sql1);
        }
        public QuanLiChungNhan(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from ChungNhan";
            dgvcn.DataSource = cnbus.DatagvFind(sql);
            txtmacn.Enabled = false;
            cbten.DisplayMember = "TenChungNhan";
            string sql1 = "select TenChungNhan from ChungNhan";
            cbten.DataSource = cnbus.LoadComboBox(sql1);
        }
        ChungNhanBUS cnbus = new ChungNhanBUS();

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string ngaycap = txtngaycap.Value.ToString("yyyy-MM-dd");
            string loai = cbloai.Text;
            if (ten.Equals("") || loai.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvcn.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmacn.Text = "MaCN001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvcn.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmacn.Text = "MaCN00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmacn.Text = "MaCN0" + (so + 1).ToString();
                }
                ChungNhan u = new ChungNhan(txtmacn.Text, ten, ngaycap, loai);
                cnbus.InsertCN(u);
                MessageBox.Show("Thêm Chứng Nhận thành công!");
                txtmacn.Text = "";
                txtten.Text = "";
                txtngaycap.Text = "";
                cbloai.Text = "";
                cbten.DisplayMember = "TenChungNhan";
                string sql1 = "select TenChungNhan from ChungNhan";
                cbten.DataSource = cnbus.LoadComboBox(sql1);
            }
            string sql = "select * from ChungNhan";
            dgvcn.DataSource = cnbus.DatagvFind(sql);
        }


        private void btnsua_Click_1(object sender, EventArgs e)
        {
                string macn = txtmacn.Text;
                string ten = txtten.Text;
                string ngaycap = txtngaycap.Value.ToString("yyyy-MM-dd");
                string loai = cbloai.Text;
                ChungNhan u = new ChungNhan(macn, ten, ngaycap, loai);
                cnbus.UpdateCN(u);
                MessageBox.Show("Chỉnh sửa thành công!");
                string sql = "select * from ChungNhan";
                dgvcn.DataSource = cnbus.DatagvFind(sql);
                txtmacn.Text = "";
                txtten.Text = "";
                txtngaycap.Text = "";
                cbloai.Text = "";
                cbten.DisplayMember = "TenChungNhan";
                string sql1 = "select TenChungNhan from ChungNhan";
                cbten.DataSource = cnbus.LoadComboBox(sql1);
            
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
                string macn = txtmacn.Text;
                string ten = txtten.Text;
                string ngaycap = txtngaycap.Value.ToString("yyyy-MM-dd");
                string loai = cbloai.Text;
                ChungNhan u = new ChungNhan(macn, ten, ngaycap, loai);
                cnbus.DeleteCN(u);
                MessageBox.Show("Xóa thành công!");
                string sql = "select * from ChungNhan";
                dgvcn.DataSource = cnbus.DatagvFind(sql);
                txtmacn.Text = "";
                txtten.Text = "";
                txtngaycap.Text = "";
                cbloai.Text = "";
                cbten.DisplayMember = "TenChungNhan";
                string sql1 = "select TenChungNhan from ChungNhan";
                cbten.DataSource = cnbus.LoadComboBox(sql1);         
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
                txtmacn.Text = "";
                txtten.Text = "";
                txtngaycap.Text = "";
                cbloai.Text = "";
                string sql = "select * from ChungNhan";
                dgvcn.DataSource = cnbus.DatagvFind(sql);
            
        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
                string sql = "select * from ChungNhan where TenChungNhan = N'" + cbten.Text + "'";
                dgvcn.DataSource = cnbus.DatagvFind(sql);
            
        }

        private void dgvcn_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                txtmacn.ReadOnly = true; //không sửa đc id
                int indexofcontent = e.RowIndex;
                DataGridViewRow dataGridViewRow = dgvcn.Rows[indexofcontent];
                txtmacn.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtten.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtngaycap.Text = dataGridViewRow.Cells[2].Value.ToString();
                cbloai.Text = dataGridViewRow.Cells[3].Value.ToString();
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu lg = new TrangChu(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
            this.Close();
        }
    }
}

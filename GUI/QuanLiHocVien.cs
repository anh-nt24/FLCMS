using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class QuanLiHocVien : Form
    {
        public QuanLiHocVien()
        {
            InitializeComponent();
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
            txtmahv.Enabled = false;
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from HocVien";
            cbten.DataSource = hvbus.LoadComboBox(sql1);
            cbmacn.DisplayMember = "MaChungNhan";
            string sql2 = "select MaChungNhan from ChungNhan";
            cbmacn.DataSource = hvbus.LoadComboBox(sql2);
        }
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiHocVien(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
            txtmahv.Enabled = false;
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from HocVien";
            cbten.DataSource = hvbus.LoadComboBox(sql1);
            cbmacn.DisplayMember = "MaChungNhan";
            string sql2 = "select MaChungNhan from ChungNhan";
            cbmacn.DataSource = hvbus.LoadComboBox(sql2);
        }
        HocVienBUS hvbus = new HocVienBUS();

        private void btnanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files (.jpg; *.png; *.bmp)|.jpg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void QuanLiHocVien_Load(object sender, EventArgs e)
        {
            dgvhv.DataSource = hvbus.DatagvFind("Select * from HocVien");
            DataGridViewImageColumn pic= new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvhv.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            byte[] anh = ImageToByteArray(pic2);
            string ten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string sdtgd = txtsdtgd.Text;
            string sdtcn = txtsdtcn.Text;
            string macn = cbmacn.Text;

            if (ten.Equals("") || diachi.Equals("") || sdtgd.Equals("") || sdtcn.Equals("") || macn.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvhv.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmahv.Text = "MaHV001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvhv.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmahv.Text = "MaHV00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmahv.Text = "MaHV0" + (so + 1).ToString();
                }
                HocVien u = new HocVien(txtmahv.Text, ten, diachi, ngaysinh, sdtgd, sdtcn, macn,anh);
                hvbus.InsertHV(u);
                MessageBox.Show("Thêm Học Viên thành công!");
                txtmahv.Text = "";
                txthoten.Text = "";
                txtdiachi.Text = "";
                txtngaysinh.Text = "";
                txtsdtgd.Text = "";
                txtsdtcn.Text = "";
                cbmacn.Text = "";
                cbten.DisplayMember = "HoTen";
                string sql1 = "select HoTen from HocVien";
                cbten.DataSource = hvbus.LoadComboBox(sql1);
            }
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
        }

        private void btnbangcn_Click(object sender, EventArgs e)
        {


        }

        private void dgvhv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahv.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvhv.Rows[indexofcontent];
            txtmahv.Text = dataGridViewRow.Cells[0].Value.ToString();
            txthoten.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtngaysinh.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtsdtgd.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtsdtcn.Text = dataGridViewRow.Cells[5].Value.ToString();
            cbmacn.Text = dataGridViewRow.Cells[6].Value.ToString();
            if (dataGridViewRow.Cells[7].Value.ToString() != "")
            {
                MemoryStream memoryStream = new MemoryStream((byte[])dataGridViewRow.Cells[7].Value);
                pic2.Image = Image.FromStream(memoryStream);
            }
            else
                pic2.Image = null;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from HocVien where HoTen = N'" + cbten.Text + "'";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmahv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            txtsdtgd.Text = "";
            txtsdtcn.Text = "";
            cbmacn.Text = "";
            pic2.Image = null;
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mahv = txtmahv.Text;
            string ten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string sdtgd = txtsdtgd.Text;
            string sdtcn = txtsdtcn.Text;
            string macn = cbmacn.Text;
            byte[] anh = ImageToByteArray(pic2);
            HocVien u = new HocVien(mahv, ten, diachi, ngaysinh, sdtgd, sdtcn, macn,anh);
            hvbus.UpdateHV(u);
            MessageBox.Show("Chỉnh sửa Học Viên thành công!");
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
            txtmahv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            txtsdtgd.Text = "";
            txtsdtcn.Text = "";
            cbmacn.Text = "";
            pic2.Image = null;

            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from HocVien";
            cbten.DataSource = hvbus.LoadComboBox(sql1);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahv = txtmahv.Text;
            string ten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string ngaysinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            string sdtgd = txtsdtgd.Text;
            string sdtcn = txtsdtcn.Text;
            string macn = cbmacn.Text;
            byte[] anh = ImageToByteArray(pic2);

            HocVien u = new HocVien(mahv, ten, diachi, ngaysinh, sdtgd, sdtcn, macn,anh);
            hvbus.DeleteHV(u);
            MessageBox.Show("Xóa Học Viên thành công!");
            string sql = "select * from HocVien";
            dgvhv.DataSource = hvbus.DatagvFind(sql);
            txtmahv.Text = "";
            txthoten.Text = "";
            txtdiachi.Text = "";
            txtngaysinh.Text = "";
            txtsdtgd.Text = "";
            txtsdtcn.Text = "";
            cbmacn.Text = "";
            pic2.Image = null;

            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from HocVien";
            cbten.DataSource = hvbus.LoadComboBox(sql1);
        }

        private void btnhd_Click(object sender, EventArgs e)
        {
            QuanLiHopDong lg = new QuanLiHopDong(MaND, HoTen, DiaChi, Sdt, Taikhoan, MatKhau, Quyen, NgaySinh, ViTriLamViec, Email);
            lg.ShowDialog();
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

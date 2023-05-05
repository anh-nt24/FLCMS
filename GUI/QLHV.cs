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
    public partial class QLHV : UserControl
    {
        public QLHV()
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
        HocVienBUS hvbus = new HocVienBUS();

        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten= txthoten.Text;
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
                HocVien u = new HocVien(txtmahv.Text, ten, diachi,ngaysinh,sdtgd,sdtcn,macn);
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
            txtdiachi.Text= dataGridViewRow.Cells[2].Value.ToString();
            txtngaysinh.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtsdtgd.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtsdtcn.Text = dataGridViewRow.Cells[5].Value.ToString();
            cbmacn.Text = dataGridViewRow.Cells[6].Value.ToString();

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
            HocVien u = new HocVien(mahv, ten, diachi, ngaysinh, sdtgd, sdtcn, macn);
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
            HocVien u = new HocVien(mahv, ten, diachi, ngaysinh, sdtgd, sdtcn, macn);
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
            cbten.DisplayMember = "HoTen";
            string sql1 = "select HoTen from HocVien";
            cbten.DataSource = hvbus.LoadComboBox(sql1);
        }
    }
}

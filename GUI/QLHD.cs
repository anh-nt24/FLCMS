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
    public partial class QLHD : UserControl
    {
        public QLHD()
        {
            InitializeComponent();
            string sql = "select * from HopDong";
            dgvhd.DataSource = hdbus.DatagvFind(sql);
            txtmahd.Enabled = false;
            cbten.DisplayMember = "TenHopDong";
            string sql1 = "select TenHopDong from HopDong";
            cbten.DataSource = hdbus.LoadComboBox(sql1);
        }
        HopDongBUS hdbus = new HopDongBUS();


        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string noidung = txtnd.Text;
            string ngaylap = txtngaylap.Value.ToString("yyyy-MM-dd");
            string thoihan = txtthoihan.Value.ToString("yyyy-MM-dd");

            if (ten.Equals("") || noidung.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvhd.Rows.Count;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0 || count == 1)
                {
                    txtmahd.Text = "MaHD001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvhd.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmahd.Text = "MaHD00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmahd.Text = "MaHD00" + (so + 1).ToString();
                }
                HopDong u = new HopDong(txtmahd.Text, ten, noidung,ngaylap,thoihan);
                hdbus.InsertHD(u);
                MessageBox.Show("Thêm hợp đồng thành công!");
                txtmahd.Text = "";
                txtten.Text = "";
                txtngaylap.Text = "";
                txtthoihan.Text = "";
                txtnd.Text = "";
                cbten.DisplayMember = "TenHopDong";
                string sql1 = "select TenHopDong from HopDong";
                cbten.DataSource = hdbus.LoadComboBox(sql1);
            }
            string sql = "select * from HopDong";
            dgvhd.DataSource = hdbus.DatagvFind(sql);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string ten = txtten.Text;
            string noidung = txtnd.Text;
            string ngaylap = txtngaylap.Value.ToString("yyyy-MM-dd");
            string thoihan = txtthoihan.Value.ToString("yyyy-MM-dd");
            HopDong u = new HopDong(mahd, ten, noidung, ngaylap, thoihan);
            hdbus.UpdateHD(u);
            MessageBox.Show("Chỉnh sửa hợp đồng thành công!");
            string sql = "select * from HopDong";
            dgvhd.DataSource = hdbus.DatagvFind(sql);
            txtmahd.Text = "";
            txtten.Text = "";
            txtngaylap.Text = "";
            txtthoihan.Text = "";
            txtnd.Text = "";
            cbten.DisplayMember = "TenHopDong";
            string sql1 = "select TenHopDong from HopDong";
            cbten.DataSource = hdbus.LoadComboBox(sql1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string ten = txtten.Text;
            string noidung = txtnd.Text;
            string ngaylap = txtngaylap.Value.ToString("yyyy-MM-dd");
            string thoihan = txtthoihan.Value.ToString("yyyy-MM-dd");
            HopDong u = new HopDong(mahd, ten, noidung, ngaylap, thoihan);
            hdbus.DeleteHD(u);
            MessageBox.Show("Xóa hợp đồng thành công!");
            string sql = "select * from HopDong";
            dgvhd.DataSource = hdbus.DatagvFind(sql);
            txtmahd.Text = "";
            txtten.Text = "";
            txtngaylap.Text = "";
            txtthoihan.Text = "";
            txtnd.Text = "";
            cbten.DisplayMember = "TenHopDong";
            string sql1 = "select TenHopDong from HopDong";
            cbten.DataSource = hdbus.LoadComboBox(sql1);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmahd.Text = "";
            txtten.Text = "";
            txtngaylap.Text = "";
            txtthoihan.Text = "";
            txtnd.Text = "";
            string sql = "select * from HopDong";
            dgvhd.DataSource = hdbus.DatagvFind(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from HopDong where TenHopDong = N'" + cbten.Text + "'";
            dgvhd.DataSource = hdbus.DatagvFind(sql);
        }

        private void dgvhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahd.ReadOnly = true; //không sửa đc id
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvhd.Rows[indexofcontent];
            txtmahd.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtten.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtnd.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtngaylap.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtthoihan.Text = dataGridViewRow.Cells[4].Value.ToString();
        }
    }
}

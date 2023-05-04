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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GUI
{
    public partial class QLKT : UserControl
    {
        public QLKT()
        {
            InitializeComponent();
            string sql = "select * from KiThi";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
            txtmakt.Enabled = false;
            cbten.DisplayMember = "TenKiThi";
            string sql1 = "select TenKiThi from KiThi";
            cbten.DataSource = ktbus.LoadComboBox(sql1);


        }
        KiThiBUS ktbus = new KiThiBUS();
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            string ngaykt = txtngaykt.Value.ToString("yyyy-MM-dd");
            string mota = txtmota.Text;
            if (ten.Equals("") || mota.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int count = 0;
                count = dgvkt.Rows.Count ;//dếm tất cả các dòng trong dgv r gán cho count
                if (count == 0)
                {
                    txtmakt.Text = "MaKT001";
                }
                else
                {
                    DataGridViewRow dataGridViewRow = dgvkt.Rows[count - 2];
                    string chuoi = dataGridViewRow.Cells[0].Value.ToString().Substring(4, 3);
                    int so = Int32.Parse(chuoi);
                    if (so < 10)
                        txtmakt.Text = "MaKT00" + (so + 1).ToString();
                    else if (so + 1 < 100)
                        txtmakt.Text = "MaKT0" + (so + 1).ToString();
                }
                KiThi u = new KiThi(txtmakt.Text, ten, ngaybd, ngaykt, mota);
                ktbus.InsertKT(u);
                MessageBox.Show("Thêm kì thi thành công!");
                txtmakt.Text = "";
                txtten.Text = "";
                txtngaybd.Text = "";
                txtngaykt.Text = "";
                txtmota.Text = "";
                cbten.DisplayMember = "TenKiThi";
                string sql1 = "select TenKiThi from KiThi";
                cbten.DataSource = ktbus.LoadComboBox(sql1);
            }
            string sql = "select * from KiThi";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string makt=txtmakt.Text;
            string ten = txtten.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            string ngaykt = txtngaykt.Value.ToString("yyyy-MM-dd");
            string mota = txtmota.Text;
            KiThi u = new KiThi(makt, ten, ngaybd, ngaykt, mota);
            ktbus.UpdateKT(u);
            MessageBox.Show("Chỉnh sửa thành công!");
            string sql = "select * from KiThi";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
            txtmakt.Text = "";
            txtten.Text = "";
            txtngaybd.Text = "";
            txtngaykt.Text = "";
            txtmota.Text = "";
            cbten.DisplayMember = "TenKiThi";
            string sql1 = "select TenKiThi from KiThi";
            cbten.DataSource = ktbus.LoadComboBox(sql1);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from KiThi where TenKiThi = N'" + cbten.Text + "'";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
        }

        private void dgvkt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtmakt.ReadOnly = true; //không sửa đc id
                int indexofcontent = e.RowIndex;
                DataGridViewRow dataGridViewRow = dgvkt.Rows[indexofcontent];
                txtmakt.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtten.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtngaybd.Text = dataGridViewRow.Cells[2].Value.ToString();
                txtngaykt.Text = dataGridViewRow.Cells[3].Value.ToString();
                txtmota.Text = dataGridViewRow.Cells[4].Value.ToString();

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmakt.Text = "";
            txtten.Text = "";
            txtngaybd.Text = "";
            txtngaykt.Text = "";
            txtmota.Text = "";
            string sql = "select * from KiThi";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string makt = txtmakt.Text;
            string ten = txtten.Text;
            string ngaybd = txtngaybd.Value.ToString("yyyy-MM-dd");
            string ngaykt = txtngaykt.Value.ToString("yyyy-MM-dd");
            string mota = txtmota.Text;
            KiThi u = new KiThi(makt, ten, ngaybd, ngaykt, mota);
            ktbus.DeleteKT(u);
            MessageBox.Show("Xóa thành công!");
            string sql = "select * from KiThi";
            dgvkt.DataSource = ktbus.DatagvFind(sql);
            txtmakt.Text = "";
            txtten.Text = "";
            txtngaybd.Text = "";
            txtngaykt.Text = "";
            txtmota.Text = "";
            cbten.DisplayMember = "TenKiThi";
            string sql1 = "select TenKiThi from KiThi";
            cbten.DataSource = ktbus.LoadComboBox(sql1);
        }
    }
}

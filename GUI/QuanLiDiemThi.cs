﻿using BUS;
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
    public partial class QuanLiDiemThi : Form
    {
        public QuanLiDiemThi()
        {
            InitializeComponent();
            string sql = "select * from DiemThi";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
            cbmahv.DisplayMember = "MaHocVien";
            string sql2 = "select MaHocVien from HocVien";
            cbmahv.DataSource = dtbus.LoadComboBox(sql2);
            cbmakt.DisplayMember = "MaKiThi";
            string sql4 = "select MaKiThi from KiThi";
            cbmakt.DataSource = dtbus.LoadComboBox(sql4);
            cbten.DisplayMember = "MaKithi";
            string sql1 = "select MaKiThi from DiemThi";
            cbten.DataSource = dtbus.LoadComboBox(sql1);
        }
        DiemThiBUS dtbus = new DiemThiBUS();
        string Taikhoan = "", MatKhau = "", Quyen = "", MaND = "", HoTen = "", DiaChi = "", Sdt = "", NgaySinh = "", ViTriLamViec = "", Email = "";

        public QuanLiDiemThi(string mand, string hoten, string diachi, string sdt, string taikhoan, string matkhau, string quyen, string ngaysinh, string vitrivieclam, string email)
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
            string sql = "select * from DiemThi";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
            cbmahv.DisplayMember = "MaHocVien";
            string sql2 = "select MaHocVien from HocVien";
            cbmahv.DataSource = dtbus.LoadComboBox(sql2);
            cbmakt.DisplayMember = "MaKiThi";
            string sql4 = "select MaKiThi from KiThi";
            cbmakt.DataSource = dtbus.LoadComboBox(sql4);
            cbten.DisplayMember = "MaKithi";
            string sql1 = "select MaKiThi from DiemThi";
            cbten.DataSource = dtbus.LoadComboBox(sql1);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahv = cbmahv.Text;
            string makt = cbmakt.Text;
            string ngaythi = txtngay.Value.ToString("yyyy-MM-dd");
            string kq = txtkq.Text;
            string dd = cbdd.Text;
            if (mahv.Equals("") || makt.Equals("") || kq.Equals("") || dd.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DiemThi u = new DiemThi(mahv, makt, ngaythi, kq, dd);
                dtbus.InsertDT(u);
                MessageBox.Show("Thêm điểm thi thành công!");
                cbmakt.Text = "";
                txtkq.Text = "";
                txtngay.Text = "";
                cbmahv.Text = "";
                cbdd.Text = "";
                cbten.DisplayMember = "MaHocVien";
                string sql1 = "select MaHocVien from DiemThi";
                cbten.DataSource = dtbus.LoadComboBox(sql1);
            }
            string sql = "select * from DiemThi";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
        }

        private void dgvdt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexofcontent = e.RowIndex;
            DataGridViewRow dataGridViewRow = dgvdt.Rows[indexofcontent];
            cbmahv.Text = dataGridViewRow.Cells[0].Value.ToString();
            cbmakt.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtngay.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtkq.Text = dataGridViewRow.Cells[3].Value.ToString();
            cbdd.Text = dataGridViewRow.Cells[4].Value.ToString();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string mahv = cbmahv.Text;
            string makt = cbmakt.Text;
            string ngaythi = txtngay.Value.ToString("yyyy-MM-dd");
            string kq = txtkq.Text;
            string dd = cbdd.Text;
            DiemThi u = new DiemThi(mahv, makt, ngaythi, kq, dd);
            dtbus.DeleteDT(u);
            MessageBox.Show("Xóa điểm thi thành công!");
            string sql = "select * from DiemThi";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
            cbmakt.Text = "";
            txtkq.Text = "";
            txtngay.Text = "";
            cbmahv.Text = "";
            cbdd.Text = "";
            cbten.DisplayMember = "MaHocVien";
            string sql1 = "select MaHocVien from DiemThi";
            cbten.DataSource = dtbus.LoadComboBox(sql1);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cbmakt.Text = "";
            txtkq.Text = "";
            txtngay.Text = "";
            cbmahv.Text = "";
            cbdd.Text = "";
            string sql = "select * from DiemThi";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from DiemThi where MaHocVien = N'" + cbten.Text + "'";
            dgvdt.DataSource = dtbus.DatagvFind(sql);
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
                string mahv = cbmahv.Text;
                string makt = cbmakt.Text;
                string ngaythi = txtngay.Value.ToString("yyyy-MM-dd");
                string kq = txtkq.Text;
                string dd = cbdd.Text;
                DiemThi u = new DiemThi(mahv, makt, ngaythi, kq, dd);
                dtbus.UpdateDT(u);
                MessageBox.Show("Sửa điểm thi thành công!");
                string sql = "select * from DiemThi";
                dgvdt.DataSource = dtbus.DatagvFind(sql);
                cbmakt.Text = "";
                txtkq.Text = "";
                txtngay.Text = "";
                cbmahv.Text = "";
                cbdd.Text = "";
          

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
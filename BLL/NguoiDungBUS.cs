using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAL nd = new NguoiDungDAL();
        public bool CheckLogin(NguoiDung nguoidung)
        {
            return nd.CheckLogin(nguoidung);
        }
        public bool CheckQuyen(NguoiDung nguoidung)
        {
            return nd.CheckQuyen(nguoidung);
        }
        public bool CheckEmail(NguoiDung nguoidung)
        {
            return nd.CheckEmail(nguoidung);
        }
        public bool Checkmkmoitrungmkcu(NguoiDung nguoidung)
        {
            return nd.Checkmkmoitrungmkcu(nguoidung);
        }
        public void Thaydoimk(NguoiDung nguoidung)
        {
            nd.Thaydoimk(nguoidung);
        }
        public void Thaydoimkkodk(NguoiDung nguoidung)
        {
            nd.Thaydoimkkodk(nguoidung);
        }
        public void InsertND(NguoiDung nguoidung)
        {
            nd.InsertND(nguoidung);
        }
        public void UpdateND(NguoiDung nguoidung)
        {
            nd.UpdateND(nguoidung);
        }
        public void DeleteND(NguoiDung nguoidung)
        {
            nd.DeleteND(nguoidung);
        }
        public string maxID(NguoiDung nguoidung)
        {
           return nd.maxID(nguoidung);
        }
        public bool ChecktontaiTaiKhoan(NguoiDung nguoidung)
        {
            return nd.ChecktontaiTaiKhoan(nguoidung);
        }
        public bool ChecktontaiEmail(NguoiDung nguoidung)
        {
            return nd.ChecktontaiEmail(nguoidung);
        }

        Database dgv = new Database();

        public DataTable DatagvDAL()
        {
            return dgv.DatagvDAL();
        }
        public DataTable DatagvFind(string sql)
        {
            return dgv.DatagvFind(sql);
        }
        public DataTable LoadComboBox(string sql)
        {
            return dgv.LoadComboBox(sql);
        }
    }
}

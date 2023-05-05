using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Win32;



namespace DAL
{
    public class SqlConnectionData
    {
        static SqlConnection conn;
        public static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\QLTTNN\DAL\QLTT.mdf;Integrated Security=True";
        public static SqlConnection GetConnection() { 
            if (conn==null)
            {
                conn= new SqlConnection(stringConnection);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }
    public class Database { 
        public static bool CheckLoginDAL(NguoiDung nguoidung)
        {
                SqlConnection connection = SqlConnectionData.GetConnection();
                string query = "SELECT COUNT(*) FROM NguoiDung WHERE nguoidung.Taikhoan = @Taikhoan and nguoidung.MatKhau=@MatKhau";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                        command.Parameters.AddWithValue("@Taikhoan", nguoidung.Taikhoan);
                        command.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
                        int count = (int)command.ExecuteScalar();
                            return count > 0;
                }
            
        }
        public static bool CheckQuyenDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "SELECT Quyen FROM NguoiDung WHERE nguoidung.Taikhoan = @Taikhoan and nguoidung.MatKhau=@MatKhau";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Taikhoan", nguoidung.Taikhoan);
                command.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
                string quyen = "admin";

                return nguoidung.Quyen == quyen;
            }

        }
        public static bool CheckEmailDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE nguoidung.Email = @Email";
            //sqlcommand dung de truy van cac cau lenh insert, delete, update
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", nguoidung.Email);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public bool CheckmkmoitrungmkcuDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "SELECT MatKhau FROM NguoiDung WHERE nguoidung.Email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", nguoidung.Email);

                string matkhaucu = (string)command.ExecuteScalar();

                return nguoidung.MatKhau == matkhaucu;
            }
        }
        public void ThaydoimkDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE NguoiDung SET nguoidung.MatKhau = @MatKhau " +
                  "WHERE nguoidung.Email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", nguoidung.Email);
                command.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
                command.ExecuteNonQuery();
            }
        }
        public void InsertNDDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO NguoiDung (MaND,HoTen,DiaChi,Sdt,Taikhoan,MatKhau,Quyen,NgaySinh,ViTriLamViec,Email) " +
                           "VALUES (@MaND,@HoTen,@DiaChi,@Sdt,@Taikhoan,@MatKhau,@Quyen,@NgaySinh,@ViTriLamViec,@Email)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaND", nguoidung.MaND);
                command.Parameters.AddWithValue("@HoTen", nguoidung.HoTen);
                command.Parameters.AddWithValue("@DiaChi", nguoidung.DiaChi);
                command.Parameters.AddWithValue("@Sdt", nguoidung.Sdt);
                command.Parameters.AddWithValue("@Taikhoan", nguoidung.Taikhoan);
                command.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
                command.Parameters.AddWithValue("@Quyen", nguoidung.Quyen);
                command.Parameters.AddWithValue("@NgaySinh", nguoidung.NgaySinh);
                command.Parameters.AddWithValue("@ViTriLamViec", nguoidung.ViTriLamViec);
                command.Parameters.AddWithValue("@Email", nguoidung.Email);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateNDDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE NguoiDung SET HoTen = @HoTen, DiaChi = @DiaChi, Sdt=@Sdt, Taikhoan=@Taikhoan, MatKhau=@MatKhau, Quyen=@Quyen, NgaySinh=@NgaySinh, ViTriLamViec=@ViTriLamViec, Email=@Email " +
                           "WHERE MaND = @MaND";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaND", nguoidung.MaND);
                command.Parameters.AddWithValue("@HoTen", nguoidung.HoTen);
                command.Parameters.AddWithValue("@DiaChi", nguoidung.DiaChi);
                command.Parameters.AddWithValue("@Sdt", nguoidung.Sdt);
                command.Parameters.AddWithValue("@Taikhoan", nguoidung.Taikhoan);
                command.Parameters.AddWithValue("@MatKhau", nguoidung.MatKhau);
                command.Parameters.AddWithValue("@Quyen", nguoidung.Quyen);
                command.Parameters.AddWithValue("@NgaySinh", nguoidung.NgaySinh);
                command.Parameters.AddWithValue("@ViTriLamViec", nguoidung.ViTriLamViec);
                command.Parameters.AddWithValue("@Email", nguoidung.Email);
                command.ExecuteNonQuery();
            }
        }
        public void deleteNDDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete NguoiDung WHERE MaND = @MaND";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaND", nguoidung.MaND);
                command.ExecuteNonQuery();

            }
        }

        //tìm mã id lớn nhất 
        public string maxIDDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaND) from NguoiDung";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaND", nguoidung.MaND);
                command.ExecuteNonQuery();
                return (nguoidung.MaND);

            }

        }
        //kt có tồn tại tài khoản auto đã tạo k
        public bool ChecktontaiTaiKhoanDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE Taikhoan = @Taikhoan";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Taikhoan", nguoidung.Taikhoan);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {               
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //kt có tồn tại email trong hệ thống ch
        public bool ChecktontaiEmailDAL(NguoiDung nguoidung)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "SELECT COUNT(*) FROM NguoiDung WHERE Email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", nguoidung.Email);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public DataTable LoadComboBox(string sql)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            //string sql = "select HoTen from NguoiDung";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                // var read = command.ExecuteReader();
                // var dt1 = new DataTable();
                //dt1.Load(read);
                //read.Dispose();
                //read = command.ExecuteReader();
                // return dt1;
                SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve
                da.SelectCommand = command;
                DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt1);  // đổ dữ liệu vào kho
                                //SqlConnection conn.Close();  // đóng kết nối
                                //đổ dữ liệu vào datagridview
                //connection.Close();
                return dt1; //đổ dữ liệu vào datagridview
            }
        }
        public DataTable DatagvDAL()
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string sql = "select * from NguoiDung";  // lay het du lieu trong bang sinh vien
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                //bat dau truy van
                command.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new SqlDataAdapter(command); //chuyen du lieu ve
                DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da1.Fill(dt1);  // đổ dữ liệu vào kho
                              //SqlConnection conn.Close();  // đóng kết nối
                              //đổ dữ liệu vào datagridview
                //connection .Close();
                return dt1; //đổ dữ liệu vào datagridview

            }
        }
        //hien thi du lieu len dgv
        public DataTable DatagvFind(string sql)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            using (SqlCommand command = new SqlCommand(sql,connection))
            {
                //bat dau truy van
                command.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new SqlDataAdapter(command); //chuyen du lieu ve
                DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                                                //SqlConnection conn.Close();  // đóng kết nối
                da1.Fill(dt1);               //đổ dữ liệu vào datagridview
                da1.Dispose();
                //connection.Close();
                return dt1; //đổ dữ liệu vào datagridview

            }
        }
        public void InsertKTDAL(KiThi kithi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO KiThi(MaKiThi,TenKiThi,ThoiGianBatDau,ThoiGianKetThuc,MoTa) " +
                           "VALUES (@MaKiThi,@TenKiThi,@ThoiGianBatDau,@ThoiGianKetThuc,@MoTa)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKiThi", kithi.MaKiThi);
                command.Parameters.AddWithValue("@TenKiThi", kithi.TenKiThi);
                command.Parameters.AddWithValue("@ThoiGianBatDau", kithi.ThoiGianBatDau);
                command.Parameters.AddWithValue("@ThoiGianKetThuc", kithi.ThoiGianKetThuc);
                command.Parameters.AddWithValue("@MoTa", kithi.MoTa);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateKTDAL(KiThi kithi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE KiThi SET TenKiThi= @TenKiThi,ThoiGianBatDau= @ThoiGianBatDau,ThoiGianKetThuc=@ThoiGianKetThuc,MoTa=@MoTa " +
                           "WHERE MaKiThi= @MaKiThi";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKiThi", kithi.MaKiThi);
                command.Parameters.AddWithValue("@TenKiThi", kithi.TenKiThi);
                command.Parameters.AddWithValue("@ThoiGianBatDau", kithi.ThoiGianBatDau);
                command.Parameters.AddWithValue("@ThoiGianKetThuc", kithi.ThoiGianKetThuc);
                command.Parameters.AddWithValue("@MoTa", kithi.MoTa);
                command.ExecuteNonQuery();
            }
        }
        public void deleteKTDAL(KiThi kithi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete KiThi WHERE MaKiThi = @MaKiThi";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKiThi", kithi.MaKiThi);
                command.ExecuteNonQuery();

            }
        }

        //tìm mã id lớn nhất 
        public string maxIDKTDAL(KiThi kithi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaKiThi) from KiThi";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKiThi", kithi.MaKiThi);
                command.ExecuteNonQuery();
                return (kithi.MaKiThi);

            }
        }
        public void InsertCNDAL(ChungNhan chungnhan)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO ChungNhan(MaChungNhan,TenChungNhan,NgayCap,XepLoai) " +
                           "VALUES (@MaChungNhan,@TenChungNhan,@NgayCap,@XepLoai)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaChungNhan", chungnhan.MaChungNhan);
                command.Parameters.AddWithValue("@TenChungNhan", chungnhan.TenChungNhan);
                command.Parameters.AddWithValue("@NgayCap", chungnhan.NgayCap);
                command.Parameters.AddWithValue("@XepLoai", chungnhan.XepLoai);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateCNDAL(ChungNhan chungnhan)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE ChungNhan SET TenChungNhan= @TenChungNhan,NgayCap= @NgayCap,XepLoai=@XepLoai " +
                           "WHERE MaChungNhan= @MaChungNhan";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaChungNhan", chungnhan.MaChungNhan);
                command.Parameters.AddWithValue("@TenChungNhan", chungnhan.TenChungNhan);
                command.Parameters.AddWithValue("@NgayCap", chungnhan.NgayCap);
                command.Parameters.AddWithValue("@XepLoai", chungnhan.XepLoai);
                command.ExecuteNonQuery();
            }
        }
        public void deleteCNDAL(ChungNhan chungnhan)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete ChungNhan WHERE MaChungNhan = @MaChungNhan";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaChungNhan", chungnhan.MaChungNhan);
                command.ExecuteNonQuery();

            }
        }

        //tìm mã id lớn nhất 
        public string maxIDCNDAL(ChungNhan chungnhan)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaChungNhan) from ChungNhan";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaChungNhan", chungnhan.MaChungNhan);
                command.ExecuteNonQuery();
                return (chungnhan.MaChungNhan);

            }
        }
        public void InsertHVDAL(HocVien hocvien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO HocVien(MaHocVien,HoTen,DiaChi,NgaySinh,SDTGiaDinh,SDTCaNhan,MaChungNhan) " +
                           "VALUES (@MaHocVien,@HoTen,@DiaChi,@NgaySinh,@SDTGiaDinh,@SDTCaNhan,@MaChungNhan)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", hocvien.MaHocVien);
                command.Parameters.AddWithValue("@HoTen", hocvien.HoTen);
                command.Parameters.AddWithValue("@DiaChi", hocvien.DiaChi);
                command.Parameters.AddWithValue("@NgaySinh", hocvien.NgaySinh);
                command.Parameters.AddWithValue("@SDTGiaDinh", hocvien.SDTGiaDinh);
                command.Parameters.AddWithValue("@SDTCaNhan", hocvien.SDTCaNhan);
                command.Parameters.AddWithValue("@MaChungNhan", hocvien.MaChungNhan);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateHVDAL(HocVien hocvien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE HocVien SET HoTen= @HoTen,DiaChi= @DiaChi,NgaySinh=@NgaySinh,SDTGiaDinh=@SDTGiaDinh,SDTCaNhan=@SDTCaNhan,MaChungNhan=@MaChungNhan " +
                           "WHERE MaHocVien= @MaHocVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", hocvien.MaHocVien);
                command.Parameters.AddWithValue("@HoTen", hocvien.HoTen);
                command.Parameters.AddWithValue("@DiaChi", hocvien.DiaChi);
                command.Parameters.AddWithValue("@NgaySinh", hocvien.NgaySinh);
                command.Parameters.AddWithValue("@SDTGiaDinh", hocvien.SDTGiaDinh);
                command.Parameters.AddWithValue("@SDTCaNhan", hocvien.SDTCaNhan);
                command.Parameters.AddWithValue("@MaChungNhan", hocvien.MaChungNhan);
                command.ExecuteNonQuery();
            }
        }
        public void deleteHVDAL(HocVien hocvien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete HocVien WHERE MaHocVien = @MaHocVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", hocvien.MaHocVien);
                command.ExecuteNonQuery();

            }
        }

        //tìm mã id lớn nhất 
        public string maxIDHVDAL(HocVien hocvien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaHocVien) from HocVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", hocvien.MaHocVien);
                command.ExecuteNonQuery();
                return (hocvien.MaHocVien);
            }
        }
        public void InsertDTDAL(DiemThi diemthi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO DiemThi(MaHocVien,MaKiThi,NgayThi,KetQuaThi,DiemDanh) " +
                           "VALUES (@MaHocVien,@MaKiThi,@NgayThi,@KetQuaThi,@DiemDanh)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", diemthi.MaHocVien);
                command.Parameters.AddWithValue("@MaKiThi", diemthi.MaKiThi);
                command.Parameters.AddWithValue("@NgayThi", diemthi.NgayThi);
                command.Parameters.AddWithValue("@KetQuaThi", diemthi.KetQuaThi);
                command.Parameters.AddWithValue("@DiemDanh", diemthi.DiemDanh);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateDTDAL(DiemThi diemthi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE DiemThi SET NgayThi= @NgayThi,KetQuaThi= @KetQuaThi,DiemDanh=@DiemDanh " +
                           "WHERE MaHocVien= @MaHocVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", diemthi.MaHocVien);
                command.Parameters.AddWithValue("@MaKiThi", diemthi.MaKiThi);
                command.Parameters.AddWithValue("@NgayThi", diemthi.NgayThi);
                command.Parameters.AddWithValue("@KetQuaThi", diemthi.KetQuaThi);
                command.Parameters.AddWithValue("@DiemDanh", diemthi.DiemDanh);
                command.ExecuteNonQuery();
            }
        }
        public void deleteDTDAL(DiemThi diemthi)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete DiemThi WHERE MaHocVien = @MaHocVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHocVien", diemthi.MaHocVien);
                command.ExecuteNonQuery();

            }
        }
        public void InsertHDDAL(HopDong hopdong)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO HopDong(MaHopDong,TenHopDong,NoiDung,NgayLap,ThoiHan) " +
                           "VALUES (@MaHopDong,@TenHopDong,@NoiDung,@NgayLap,@ThoiHan)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHopDong", hopdong.MaHopDong);
                command.Parameters.AddWithValue("@TenHopDong", hopdong.TenHopDong);
                command.Parameters.AddWithValue("@NoiDung", hopdong.NoiDung);
                command.Parameters.AddWithValue("@NgayLap", hopdong.NgayLap);
                command.Parameters.AddWithValue("@ThoiHan", hopdong.ThoiHan);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateHDDAL(HopDong hopdong)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE HopDong SET TenHopDong= @TenHopDong,NoiDung= @NoiDung,NgayLap=@NgayLap,ThoiHan=@ThoiHan " +
                           "WHERE MaHopDong= @MaHopDong";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHopDong", hopdong.MaHopDong);
                command.Parameters.AddWithValue("@TenHopDong", hopdong.TenHopDong);
                command.Parameters.AddWithValue("@NoiDung", hopdong.NoiDung);
                command.Parameters.AddWithValue("@NgayLap", hopdong.NgayLap);
                command.Parameters.AddWithValue("@ThoiHan", hopdong.ThoiHan);
                command.ExecuteNonQuery();
            }
        }
        public void deleteHDDAL(HopDong hopdong)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete HopDong WHERE MaHopDong = @MaHopDong";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHopDong", hopdong.MaHopDong);
                command.ExecuteNonQuery();

            }
        }
        public string maxIDHDDAL(HopDong hopdong)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaHopDong) from HopDong";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHopDong", hopdong.MaHopDong);
                command.ExecuteNonQuery();
                return (hopdong.MaHopDong);
            }
        }
        public void InsertLHDAL(LopHoc lophoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO LopHoc(MaLop,TenLop,TenPhongHoc,NgayBatDau) " +
                           "VALUES (@MaLop,@TenLop,@TenPhongHoc,@NgayBatDau)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaLop", lophoc.MaLop);
                command.Parameters.AddWithValue("@TenLop", lophoc.TenLop);
                command.Parameters.AddWithValue("@TenPhongHoc", lophoc.TenPhongHoc);
                command.Parameters.AddWithValue("@NgayBatDau", lophoc.NgayBatDau);
                command.ExecuteNonQuery();
            }
        }
        public void deleteLHDAL(LopHoc lophoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete LopHoc WHERE MaLop = @MaLop";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaLop", lophoc.MaLop);
                command.ExecuteNonQuery();

            }
        }
        public void UpdateLHDAL(LopHoc lophoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE LopHoc SET TenLop= @TenLop,TenPhongHoc= @TenPhongHoc,NgayBatDau=@NgayBatDau " +
                           "WHERE MaLop= @MaLop";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaLop", lophoc.MaLop);
                command.Parameters.AddWithValue("@TenLop", lophoc.TenLop);
                command.Parameters.AddWithValue("@TenPhongHoc", lophoc.TenPhongHoc);
                command.Parameters.AddWithValue("@NgayBatDau", lophoc.NgayBatDau);
                command.ExecuteNonQuery();
            }
        }
        public string maxIDLHDAL(LopHoc lophoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaLop) from LopHoc";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaLop", lophoc.MaLop);
                command.ExecuteNonQuery();
                return (lophoc.MaLop);
            }
        }
        public void InsertKHDAL(KhoaHoc khoahoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO KhoaHoc(MaKH,TenKhoaHoc,CapDo,SoBuoi,HocPhi,MaLop) " +
                           "VALUES (@MaKH,@TenKhoaHoc,@CapDo,@SoBuoi,@HocPhi,@MaLop)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKH", khoahoc.MaKH);
                command.Parameters.AddWithValue("@TenKhoaHoc", khoahoc.TenKhoaHoc);
                command.Parameters.AddWithValue("@CapDo", khoahoc.CapDo);
                command.Parameters.AddWithValue("@SoBuoi", khoahoc.SoBuoi);
                command.Parameters.AddWithValue("@HocPhi", khoahoc.HocPhi);
                command.Parameters.AddWithValue("@MaLop", khoahoc.MaLop);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateKHDAL(KhoaHoc khoahoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE KhoaHoc SET TenKhoaHoc= @TenKhoaHoc,CapDo= @CapDo,SoBuoi=@SoBuoi,HocPhi=@HocPhi,MaLop=@MaLop " +
                           "WHERE MaKH= @MaKH";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKH", khoahoc.MaKH);
                command.Parameters.AddWithValue("@TenKhoaHoc", khoahoc.TenKhoaHoc);
                command.Parameters.AddWithValue("@CapDo", khoahoc.CapDo);
                command.Parameters.AddWithValue("@SoBuoi", khoahoc.SoBuoi);
                command.Parameters.AddWithValue("@HocPhi", khoahoc.HocPhi);
                command.Parameters.AddWithValue("@MaLop", khoahoc.MaLop);
                command.ExecuteNonQuery();
            }
        }
        public void deleteKHDAL(KhoaHoc khoahoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete KhoaHoc WHERE MaKH = @MaKH";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKH", khoahoc.MaKH);
                command.ExecuteNonQuery();

            }
        }
        public string maxIDKHDAL(KhoaHoc khoahoc)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaKH) from KhoaHoc";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKH", khoahoc.MaKH);
                command.ExecuteNonQuery();
                return (khoahoc.MaKH);
            }
        }
        public void InsertGVDAL(GiaoVien giaovien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "INSERT INTO GiaoVien(MaGiaoVien,HoTen,DiaChi,Sdt,NgaySinh,NgayVaoLam,ChuyenMon,BangCap,MaHopDong,MaLop) " +
                           "VALUES (@MaGiaoVien,@HoTen,@DiaChi,@Sdt,@NgaySinh,@NgayVaoLam,@ChuyenMon,@BangCap,@MaHopDong,@MaLop)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaGiaoVien", giaovien.MaGiaoVien);
                command.Parameters.AddWithValue("@HoTen", giaovien.HoTen);
                command.Parameters.AddWithValue("@DiaChi", giaovien.DiaChi);
                command.Parameters.AddWithValue("@Sdt", giaovien.Sdt);
                command.Parameters.AddWithValue("@NgaySinh", giaovien.NgaySinh);
                command.Parameters.AddWithValue("@NgayVaoLam", giaovien.NgayVaoLam);
                command.Parameters.AddWithValue("@ChuyenMon", giaovien.ChuyenMon);
                command.Parameters.AddWithValue("@BangCap", giaovien.BangCap);
                command.Parameters.AddWithValue("@MaHopDong", giaovien.MaHopDong);
                command.Parameters.AddWithValue("@MaLop", giaovien.MaLop);
                command.ExecuteNonQuery();
            }
        }
        public void UpdateGVDAL(GiaoVien giaovien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "UPDATE GiaoVien SET HoTen= @HoTen,DiaChi= @DiaChi,Sdt=@Sdt,NgaySinh=@NgaySinh,NgayVaoLam=@NgayVaoLam,ChuyenMon=@ChuyenMon,BangCap=@BangCap,MaHopDong=@MaHopDong,MaLop=@MaLop " +
                           "WHERE MaGiaoVien= @MaGiaoVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaGiaoVien", giaovien.MaGiaoVien);
                command.Parameters.AddWithValue("@HoTen", giaovien.HoTen);
                command.Parameters.AddWithValue("@DiaChi", giaovien.DiaChi);
                command.Parameters.AddWithValue("@Sdt", giaovien.Sdt);
                command.Parameters.AddWithValue("@NgaySinh", giaovien.NgaySinh);
                command.Parameters.AddWithValue("@NgayVaoLam", giaovien.NgayVaoLam);
                command.Parameters.AddWithValue("@ChuyenMon", giaovien.ChuyenMon);
                command.Parameters.AddWithValue("@BangCap", giaovien.BangCap);
                command.Parameters.AddWithValue("@MaHopDong", giaovien.MaHopDong);
                command.Parameters.AddWithValue("@MaLop", giaovien.MaLop);
                command.ExecuteNonQuery();
            }
        }
        public void deleteGVDAL(GiaoVien giaovien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Delete GiaoVien WHERE MaGiaoVien = @MaGiaoVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaGiaoVien", giaovien.MaGiaoVien);
                command.ExecuteNonQuery();

            }
        }
        public string maxIDGVDAL(GiaoVien giaovien)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "Select Max(MaGiaoVien) from GiaoVien";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaGiaoVien", giaovien.MaGiaoVien);
                command.ExecuteNonQuery();
                return (giaovien.MaGiaoVien);
            }
        }
    }
}

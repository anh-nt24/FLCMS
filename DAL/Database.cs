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
        public DataTable LoadComboBox()
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            string query = "select HoTen from NguoiDung";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var read = command.ExecuteReader();
                var dt1 = new DataTable();
                dt1.Load(read);
                read.Dispose();
                read = command.ExecuteReader();
                return dt1;
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
                SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                              //SqlConnection conn.Close();  // đóng kết nối
                              //đổ dữ liệu vào datagridview
                return dt; //đổ dữ liệu vào datagridview

            }
        }
        public DataTable DatagvFind(string sql)
        {
            SqlConnection connection = SqlConnectionData.GetConnection();
            using (SqlCommand command = new SqlCommand(sql,connection))
            {
                //bat dau truy van
                command.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(command); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                                                //SqlConnection conn.Close();  // đóng kết nối
                da.Fill(dt);               //đổ dữ liệu vào datagridview
                return dt; //đổ dữ liệu vào datagridview

            }
        }
    }
}

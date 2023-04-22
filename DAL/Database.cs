using System;
using System.Collections.Generic;
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
    }
}

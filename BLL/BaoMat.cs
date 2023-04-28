using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoMat
    {
        static string salt = "AHKJDQL";
        public static string SaltedHash(string password)
        {
            return Hash(Hash(password) + salt);
        }
        public static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    //chu thuong thi "x2"
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        public static string Macaptcha() //tận dụng làm mật khẩu luôn
        {
            Random rd = new Random();
            string chuhoa = "";

            string sorandom1 = rd.Next(100, 999).ToString();
            string sorandom2 = rd.Next(10, 99).ToString();

            for (int i = 0; i < 2; i++)
            {
                string s = Convert.ToString((char)rd.Next(65, 90));
                chuhoa = chuhoa + s;
            }
            //Chữ in hoa. Chữ thường:
            string chuthuong = Convert.ToString((char)rd.Next(97, 122));
            string chuoicaptcha = sorandom1 + chuhoa + sorandom2 + chuthuong;
            return chuoicaptcha;
        }
        public static string Mataikhoan()
        {
            Random rd1 = new Random();
            string chuhoa = "";

            string sorandom1 = rd1.Next(100, 999).ToString();
            string sorandom2 = rd1.Next(10, 99).ToString();

            for (int i = 0; i < 2; i++)
            {
                string s = Convert.ToString((char)rd1.Next(65, 90));
                chuhoa = chuhoa + s;
            }
            //Chữ in hoa. Chữ thường:
            string chuthuong = Convert.ToString((char)rd1.Next(97, 122));
            string chuoicaptcha = sorandom1 + chuthuong + sorandom2 + chuhoa;
            return "ND"+chuoicaptcha;
        }

    }
}

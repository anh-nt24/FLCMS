using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BUS;
using DAL;
using DTO;
namespace LoginTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
                // Arrange
                string username = "thanhnga";
                string password = "1456826";
                bool expected = false;

                // Act
                NguoiDung nd = new NguoiDung(username,BaoMat.SaltedHash(password));
                NguoiDungBUS ndbus=new NguoiDungBUS();
                bool actual = ndbus.CheckLogin(nd);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

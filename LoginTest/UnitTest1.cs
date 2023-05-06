using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BUS;
using DAL;
using DTO;
namespace LoginTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                // Arrange
                string username = "thanhnga";
                string password = "1234567";
                bool expected = true;

                // Act
                NguoiDung nd = new NguoiDung(username,BaoMat.SaltedHash(password));
                NguoiDungBUS ndbus=new NguoiDungBUS();
                bool actual = ndbus.CheckLogin(nd);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DTO;
using DAO;
namespace QuanLyTester
{
        [TestClass]
        public class TestLogin
        {
            private LoginDAO lgDAO = new LoginDAO();
            private Account lg;
            private Account lgs;
            private Account lgNullID;
            private Account lgNullPass;
            private Account lgEmpty;

            [TestInitialize]
            public void Setup()
            {
                this.lg = new Account("admin", "123");
                this.lgs = new Account("nv3", "321");
                this.lgNullID = new Account("", "123");
                this.lgNullPass = new Account("nv2", "");
                this.lgEmpty = new Account("", "");
            }
            [TestMethod]
            public void TestDangNhap()
            {
                bool ok = lgDAO.Login(lg);
                Assert.AreEqual(ok, lgDAO.Login(lg));
            }

            [TestMethod]
            public void TestDangNhapSai()
            {
                bool expected = false;
                bool actual = true;
                if (lgDAO.Login(lgs) == false)
                {
                    actual = false;

                }
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestDangNhapNullID()
            {
                bool expected = false;
                bool actual = true;
                if (lgDAO.Login(lgNullID) == false)
                {
                    actual = false;

                }
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestDangNhapNullPass()
            {
                bool expected = false;

                bool actual = true;
                if (lgDAO.Login(lgNullPass) == false)
                {
                    actual = false;

                }
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void TestDangNhapEmpty()
            {
                bool expected = false;
                bool actual = true;
                if (lgDAO.Login(lgEmpty) == false)
                {
                    actual = false;

                }
                Assert.AreEqual(expected, actual);
            }
        }
    }

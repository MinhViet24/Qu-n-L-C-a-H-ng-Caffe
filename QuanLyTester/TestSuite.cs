using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo;
using DTO;
namespace QuanLyTester
{
    [TestClass]
    public class TestSuite1
    {
        private QuanLySanPham ql;
        private Product pr1;
        private Product pr2;
        private Product pr3;
        private Product pr4;

        [TestInitialize]
        public void SetUp()
        {
            this.ql = new QuanLySanPham();
            this.pr1 = new BacSiu("BacSiu", "BacSiu", 10000, 15000, 1, "Minh Viet");
            this.pr2 = new SuaTuoi("SuaTuoi", "SuaTuoi", 10000, 15000, 1, "Minh Viet");
            this.pr3 = new Pepsi("Pepsi", "Pepsi", 10000, 15000, 1, "Minh Viet");
            this.pr4 = new Coca("Coca", "Coca", 10000, 15000, 1, "Minh Viet");

        }

        [TestMethod]
        public void TestThemNhanVien()
        {
            this.ql.ThemSanPham(this.pr1);
            Assert.AreEqual(1, this.ql.DsSanPham.Count);
            Assert.AreEqual("1", this.ql.DsSanPham[0].Id);
            Assert.AreEqual("BacSiu", this.ql.DsSanPham[0].Name);

            this.ql.ThemSanPham(this.pr2);
            Assert.AreEqual(1, this.ql.DsSanPham.Count);

            this.ql.ThemSanPham(this.pr3);
            Assert.AreEqual(2, this.ql.DsSanPham.Count);
            Assert.AreEqual("2", this.ql.DsSanPham[1].Name);
            Assert.AreEqual("Coca", this.ql.DsSanPham[1].categoryId);
        }

        [TestMethod]
        public void TestXoaNhanVien()
        {
            this.ql.ThemSanPham(pr1);
            this.ql.ThemSanPham(pr2);
            this.ql.ThemSanPham(pr3);
            Assert.AreEqual(3, this.ql.DsSanPham.Count);

            this.ql.XoaSanPham(this.pr4);
            Assert.AreEqual(3, this.ql.DsSanPham.Count);

            this.ql.XoaSanPham(pr2);
            Assert.AreEqual(2, this.ql.DsSanPham.Count);
            this.ql.XoaSanPham(pr1);
            Assert.AreEqual(1, this.ql.DsSanPham.Count);
            this.ql.XoaSanPham(pr3);
            Assert.AreEqual(0, this.ql.DsSanPham.Count);
        }

    }
}  

        
        


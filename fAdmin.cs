using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace QuanLyCuaHangCaffee
{
    public partial class fAdmin : Form
    {
        ProductBUS productBUS =new ProductBUS();
        LoginBUS loginBus = new LoginBUS();
        ProductCategoryBUS productCategoryBus = new ProductCategoryBUS();

        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            List<Product> list = new ProductBUS().GetProduct();
            dgvFood.DataSource = list;

            List<Account> list1 = new LoginBUS().GetAccount();
            dgvAccount.DataSource = list1;

            List<Tables> list2 = new TablesBUS().GetTable();
            dgvTable.DataSource = list2;

            List<ProductCategory> list3 = new ProductCategoryBUS().GetProductCategory();
            dgvCategory.DataSource = list3;
           
        }

        private void btAddFood_Click(object sender, EventArgs e)
        {
            string id, name, supplierId;
            float purchasePrice, sellingPrice;
            int categoryId;

            id = txtFoodID.Text;
            name = txtFoodName.Text;
            purchasePrice = float.Parse(txtPurchase.Text);
            sellingPrice = float.Parse(txtSell.Text);
            categoryId = int.Parse(txtFoodCategory.Text);
            //categoryId = int.Parse(cboFoodCategory.SelectedValue.ToString());
            supplierId = txtNCC.Text;

            Product product = new Product(id, name, purchasePrice, sellingPrice, categoryId, supplierId);

            try
            {
                int numberOfRows = productBUS.Add(product);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm" + ex.Message);
            }
        }

        private void btDeleteFood_Click(object sender, DataGridViewCellEventArgs e)
        {

            int row = dgvFood.CurrentCell.RowIndex;
            string Id = "";
            MessageBox.Show("vị trí là: " + row.ToString());
            if (dgvFood.Rows[row].Selected == true)
            {
                if (row >= 0 && row <= dgvFood.Rows.Count)
                    Id = dgvFood.Rows[e.RowIndex].Cells["id"].Value.ToString();
                int num = new ProductBUS().Delete(Id);

                List<Product> list = new ProductBUS().GetProduct();
                dgvFood.DataSource = list;
            }

        }

        private void btDeleteFood_Click(object sender, EventArgs e)
        {

            int row = dgvFood.CurrentCell.RowIndex;
            string Id = "";

            if (dgvFood.Rows[row].Selected == true)
            {
                if (row >= 0 && row < dgvFood.Rows.Count)
                    Id = dgvFood.Rows[row].Cells["id"].Value.ToString();
                int num = new ProductBUS().Delete(Id);

                List<Product> list = new ProductBUS().GetProduct();
                dgvFood.DataSource = list;
            }
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            string userName, pass;
            int type;
            userName = txtUserName.Text;
            pass = txtPass.Text;
            type = int.Parse(txtLoaiTK.Text);
            
            Account account = new Account(userName,pass,type);

            try
            {
                int numberOfRows = loginBus.AddAccount(account);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm" + ex.Message);
            }
        }

        private void btEditFood_Click(object sender, EventArgs e)
        {
            string id, name, supplierId;
            float purchasePrice, sellingPrice;
            int categoryId;

            id = txtFoodID.Text;
            name = txtFoodName.Text;
            
            purchasePrice = float.Parse(txtPurchase.Text);

            sellingPrice = float.Parse(txtSell.Text);

            categoryId = int.Parse(txtFoodCategory.Text);
            supplierId = txtNCC.Text;

            Product product = new Product(id, name, purchasePrice, sellingPrice, categoryId, supplierId);
            try
            {
                int number = new ProductBUS().Edit(product);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể sửa.\n" + ex.Message);

            }
            List<Product> list = new ProductBUS().GetProduct();

            dgvFood.DataSource = list;
        }

        private void btAddCategory_Click(object sender, EventArgs e)
        {
            string id, name;
            id= txtCategoryID.Text;
            name = txtNameCategory.Text;

            ProductCategory productCategory = new ProductCategory(id, name);

            try
            {
                int num = productCategoryBus.AddCategory(productCategory);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm" + ex.Message);
            }
        }

        private void btEditAccount_Click(object sender, EventArgs e)
        {
            string name, pass;

            name = txtUserName.Text;
            pass = txtPass.Text;

            Account account = new Account(name, pass);
            try
            {
                int number = new LoginBUS().EditAccount(account);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể sửa.\n" + ex.Message);

            }
            List<Product> list = new ProductBUS().GetProduct();

            dgvFood.DataSource = list;
        }
        

        private void btDeleteCategory_Click(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvCategory.CurrentCell.RowIndex;
            string Id = "";
            if (dgvCategory.Rows[row].Selected == true)
            {
                if (row >= 0 && row <= dgvCategory.Rows.Count)
                    Id = dgvCategory.Rows[e.RowIndex].Cells["id"].Value.ToString();
                int num = new ProductCategoryBUS().DeleteCategory(Id);

                List<ProductCategory> list = new List<ProductCategory>();
                dgvCategory.DataSource = list;

            }
        }

        private void btEditCategory_Click(object sender, EventArgs e)
        {
            string name, id;

            name = txtNameCategory.Text;
            id = txtCategoryID.Text;

            ProductCategory productCategory = new ProductCategory(id, name);
            try
            {
                int number = new ProductCategoryBUS().EditCategory(productCategory);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể sửa.\n" + ex.Message);

            }
            List<ProductCategory> list = new ProductCategoryBUS().GetProductCategory();
            dgvCategory.DataSource = list;
        }

    }
}

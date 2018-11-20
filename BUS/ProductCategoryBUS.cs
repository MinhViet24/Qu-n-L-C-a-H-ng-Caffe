using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class ProductCategoryBUS
    {
        ProductCategoryDAO productCategoryDao = new ProductCategoryDAO();

        public List<ProductCategory> GetProductCategory()
        {
            try
            {
                return productCategoryDao.GetProductCategory();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int AddCategory(ProductCategory productCategory)
        {
            try
            {
                return productCategoryDao.AddCategory(productCategory);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int DeleteCategory(string id)
        {
            try
            {
                return productCategoryDao.DeleteCategory(id);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int EditCategory(ProductCategory productCategory)
        {
            try
            {
                return productCategoryDao.EditCategory(productCategory);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }


}

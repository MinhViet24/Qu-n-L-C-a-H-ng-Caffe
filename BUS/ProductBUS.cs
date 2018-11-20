using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
    public class ProductBUS
    {
        ProductDAO productDAO = new ProductDAO();

        public List<Product> GetProduct()
        {
            try
            {
                return productDAO.GetProduct();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Add(Product product)
        {
            try
            {
                return productDAO.Add(product);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int Delete(string id)
        {
            try
            {
                return productDAO.Delete(id);
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }

        public int Edit(Product product)
        {
            try
            {
                return new ProductDAO().Edit(product);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
